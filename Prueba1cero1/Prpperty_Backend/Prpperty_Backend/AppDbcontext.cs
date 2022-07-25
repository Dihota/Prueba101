using Microsoft.EntityFrameworkCore;
using Prpperty_Backend.Models;
using System.Reflection;

namespace Prpperty_Backend
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions options) : base(options)
        {

        }

        //Api_Fluente
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Property> Propertyes { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }
        public DbSet<PropertyTrace> PropertyTraces { get; set; }




    }
}
