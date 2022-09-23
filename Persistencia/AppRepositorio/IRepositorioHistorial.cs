using System.Collections.Generic;
using Dominio;

namespace TallerMecanica.Persistencia
{
 public interface IRepositorioHistorial
 {
    IEnumerable<Historial> GetAllHistoriales();
      Historial AddHistorial(Historial historial);
      Historial UpdateHistorial(Historial historial);
      void DeleteHistorial(int Id_Historial);
      Historial GetHistorial(int Id_Historial);
 }

}
