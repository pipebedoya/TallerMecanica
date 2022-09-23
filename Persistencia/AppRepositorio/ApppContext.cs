using System;
using Dominio;
using Microsoft.EntityFrameworkCore;


namespace TallerMecanica.Persistencia
{
    public class ApppContext: DbContext
    {
        private const string connectionString = @"Data Source=localhost;Initial Catalog=DataBase;Integrated Security=True;";
        //public DbSet<Persona> personas {get; set;}
        //public DbSet<Vehiculo> Vehiculos {get; set;}
        public DbSet<Tecnico> tecnicos {get; set;}
        public DbSet<Cliente> clientes {get; set;}
        public DbSet<Historial> historiales{get;set;}
        public DbSet<Reparacion> reparaciones{get;set;}
        public ApppContext()
        {}

        public ApppContext(DbContextOptions<ApppContext> options):base(options)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}


//using Microsoft.EntityFrameworkCore;
//using System;
//namespace TallerMecanica.Persistencia
//{
    //public class AppContext : DbContext

    //{
        //public DbSet<Persona> Personas {set;get;}
        //public DbSet<Vehiculo> Vehiculos {set;get;}
    
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       //{ 
           //if(!optionsBuilder.IsConfigured )
           //{
            /*optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EfCoreDb;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);*/
            /*optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLlocalDB; Initial Catalog=Data");*/
           //}
      // }



   // } 
//}