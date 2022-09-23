using System.Collections.Generic;
using Dominio;

namespace TallerMecanica.Persistencia
{
 public interface IRepositorioReparacion
 {
      IEnumerable<Reparacion> GetAllReparacion();
      Reparacion AddReparacion(Reparacion reparacion);
      Reparacion UpdateReparacion(Reparacion reparacion);
      void DeleteReparacion(int Id_Reparacion);
      Reparacion GetReparacion(int Id_Reparacion);
 }

}
