using System.Collections.Generic;
using System.Linq; 
using Dominio;

namespace TallerMecanica.Persistencia
{
    public class RepositorioHistorial : IRepositorioHistorial
    {
    private readonly AppContext _appContext; 

    Historia IRepositorioHistorial.AddHistorial (Historial historial) 
    {
        var historialAdicionado=_appcontext.Historias.Add(historial);
       _appcontext.Savechanges();
       return historialAdicionado.Entity;
    }

    void IRepositorioHistorial.DeleteHistorial(Historial historial){

        var historialEncontrado=_appContex.Historias.FirstOrDefault(h=> h.Id == Id_Historial);
        if (historialncontrado == null)
            return;
        _appContex.Historiales.Remove(historialEncontrado);
        _appContex.Savechanges();
    }

  
    IEnumerable<Historial> IRepositorioHistorial.GetAllHistoriales()
    {
       return _appContex.Historiales;
    }

    Historial IRepositorioHistorial.GetHistorial(int Id_Historial)
    {
      return _appContex.Historiales.FirstOrDefault(r=> r.Id == Id_Historial);
    }

    Historial IRepositorioHistorial.UpdateHistorial(Historial historial)
    {
    var historialEncontrado=_appContex.Historiales.FirstOrDefault(r=> r.Id == Historial.Id);
    if(historialEncontrado!= null)
    { 
      historialEncontrado.Id_factura= Historial.Id_factura;
      historialEncontrado.Iva= Historial.Iva;
      historialEncontrado.Total=Historial.Total;
      hisorialEncontrado.Fecha_Entrada_Salida= Historial.Fecha_Entrada_Salida;
      historialEncontrado.Hora_Entrada_Salida= Historial.Hora_Entrada_Salida;
      historialEncontrado.Id_Cliente= Historial.Id_Cliente;


      _appContext.Savechanges();
    }
       return historialEncontrado; 
    }

    }

}