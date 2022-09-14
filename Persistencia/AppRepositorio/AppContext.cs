using Microsoft.EntityFrameworkCore;
namespace TallerMecanica.Persistencia
{
    public class AppContext : DbContext

    {
        public DbSet<Persona> Personas {set;get;}
    
        /*protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)

       { 
           if(!optionsBuilder.IsConfigured )
           {
            optionsBuilder
            .UseSqlserver("Data Source = (localDb)\\MSSQLlocalDb; Initial Catalog =TallerMecanicaData");
           }
       }*/



    } 
}