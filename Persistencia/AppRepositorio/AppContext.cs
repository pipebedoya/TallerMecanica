using Microsoft.EntityFrameworkCore;
using System;
namespace TallerMecanica.Persistencia
{
    public class AppContext : DbContext

    {
        public DbSet<Persona> Personas {set;get;}
        public DbSet<Vehiculo> Vehiculos {set;get;}
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       { 
           if(!optionsBuilder.IsConfigured )
           {
            /*optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EfCoreDb;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);*/
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLlocalDB; Initial Catalog=Data");
           }
       }



    } 
}