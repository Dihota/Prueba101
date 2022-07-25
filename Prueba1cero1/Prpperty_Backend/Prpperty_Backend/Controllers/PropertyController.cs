using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prpperty_Backend.Models;


namespace Prpperty_Backend.Controllers
{
    [ApiController]
    [Route("api/Propertys")]
    public class PropertyController : ControllerBase
    {
        private readonly AppDbcontext contex;

        public PropertyController( AppDbcontext contex)
        {
            this.contex = contex;
        }

        //Metodo que retorna la lista de propiedades registradas
        [HttpGet]
        public dynamic GetProperty()
        {
            try
            {
                var productos =
                from data in this.contex.Propertyes
                join own in this.contex.Owners on data.ownerIdOwner equals own.IdOwner
                join img in this.contex.PropertyImages on data.IdProperty equals img.propertyIdProperty
                select new
                {
                    idProperty = data.IdProperty,
                    name = data.Name,
                    address = data.Address,
                    price = data.Price.ToString("C"),
                    codeInternal = data.CodeInternal,
                    Idownwer = own.IdOwner,
                    nameOwner = own.Name,
                    img = img.Ruta

                };
                return productos;

            }
            catch (Exception Error)
            {

                return Error;
            }

        }

        //Metodo que Filtar el resultado de propiedades
        [HttpGet("Filter")]
        public dynamic GetPropertyFilter(string city)
        {
            try
            {
                if (city == string.Empty || city is null)
                {
                  
                    return GetProperty();
                }
                var productos =
                from data in this.contex.Propertyes
                join own in this.contex.Owners on data.ownerIdOwner equals own.IdOwner
                join img in this.contex.PropertyImages on data.IdProperty equals img.propertyIdProperty
                where data.Address.Contains(city)
                select new
                {
                    idProperty = data.IdProperty,
                    name = data.Name,
                    address = data.Address,
                    price = data.Price.ToString("C"),
                    codeInternal = data.CodeInternal,
                    Idownwer = own.IdOwner,
                    nameOwner = own.Name,
                    img = img.Ruta

                };

                if (productos is null)
                {
                    return NotFound();
                }
                else
                {
                    return productos;
                }

            }
            catch (Exception Error)
            {

                return Error;
            }
            
        }

    }
}
