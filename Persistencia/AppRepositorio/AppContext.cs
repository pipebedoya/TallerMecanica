using Microsoft.EntityFrameworkCore;
namespace TallerMecanica.Persistencia
{
    public class AppContext : DbContext

    {
        public DbSet<Persona> Personas {set;get;}
    }



}