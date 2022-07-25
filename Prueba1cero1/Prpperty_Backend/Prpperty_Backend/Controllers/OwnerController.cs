using Microsoft.AspNetCore.Mvc;
using Prpperty_Backend.Models;

namespace Prpperty_Backend.Controllers
{
    [ApiController]
    [Route("api/Owners")]
    public class OwnerController : ControllerBase
    {
        private readonly AppDbcontext context;

        public OwnerController(AppDbcontext context)
        {
            this.context = context;
        }

        //Metodo que retorna el listado de Owner
        [HttpGet]
        public List<Owner> GetOwnerS()
        {
            var owners = from datos in this.context.Owners 
                         orderby datos.Name 
                         select datos;

            return owners.ToList();
        }

        //Metodo para obtener los owner filtrado
        [HttpGet("obtener")]
        public dynamic GetOOwner(int Id)
        {
            var Owner = from datos in this.context.Owners 
                        where datos.IdOwner == Id  
                        select datos ;

            if (Owner is null)
            {
                return NotFound();
            }

            return Owner.ToList();
        }


        //Metodo para agregar owner
        [HttpPost]
        public void AddOwner(string name,string Address, DateTime Birthday)
        {
            Owner owner = new Owner();
            owner.Name = name;
            owner.Address = Address;
            owner.Birthday = Birthday; 
            this.context.Add(owner);
            this.context.SaveChanges();
        }
    }
}
