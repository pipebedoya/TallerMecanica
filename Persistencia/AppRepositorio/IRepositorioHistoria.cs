using System.Collections.Generic;
using Dominio;

namespace TallerMecanica.Persistencia
{
 public interface IRepositorioHistoria
 {
    IEnumerable<Historia> GetAllHistorias();
      Historia AddHistoria(Historia historia);
      Historia UpdateHistoria(Historia historia);
      void DeleteHistoria(int Id_Historia);
      Historia GetHistoria(int Id_Historia);
 }

}
