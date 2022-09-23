using System.Collections.Generic;
using Dominio;

namespace TallerMecanica.Persistencia
{
 public interface IRepositorioTecnico
 {      
      Tecnico AddTecnico(Tecnico tecnico);
      IEnumerable<Tecnico> GetAllTecnico();
      Tecnico UpdateTecnico(Tecnico tecnico);
      void DeleteTecnico(int Id_Tecnico);
      Tecnico GetTecnico(int Id_Tecnico);
 }

}
