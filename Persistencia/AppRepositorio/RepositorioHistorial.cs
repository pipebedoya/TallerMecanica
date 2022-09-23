using System.Collections.Generic;
using System;
using System.Linq; 
using Dominio;

namespace TallerMecanica.Persistencia
{
    public class RepositorioHistorial : IRepositorioHistorial
    {
    private readonly ApppContext _appContext; 
    public RepositorioHistorial(ApppContext appContext)
          {
               _appContext = appContext;
          }

    Historial IRepositorioHistorial.AddHistorial (Historial historial) 
    {
        var historialAdicionado=_appContext.historiales.Add(historial);
       _appContext.SaveChanges();
       return historialAdicionado.Entity;
    }

    void IRepositorioHistorial.DeleteHistorial(int Id_Historial){

        var historialEncontrado=_appContext.historiales.FirstOrDefault(h=> h.Id == Id_Historial);
        if (historialEncontrado == null)
            return;
        _appContext.Remove(historialEncontrado);
        _appContext.SaveChanges();
    }

  
    IEnumerable<Historial> IRepositorioHistorial.GetAllHistorial()
    {
       return _appContext.historiales;
    }

    Historial IRepositorioHistorial.GetHistorial(int Id_Historial)
    {
      return _appContext.historiales.FirstOrDefault(r=> r.Id == Id_Historial);
    }

    Historial IRepositorioHistorial.UpdateHistorial(Historial historial)
    {
    var historialEncontrado=_appContext.historiales.FirstOrDefault(r=> r.Id == historial.Id);
    if(historialEncontrado!= null)
    { 
      //historialEncontrado.Id_factura= Historial.Id_factura;
      //historialEncontrado.Iva= Historial.Iva;
      //historialEncontrado.Total=Historial.Total;
      historialEncontrado.Fecha_Entrada_Salida= historial.Fecha_Entrada_Salida;
      historialEncontrado.Hora_Entrada_Salida= historial.Hora_Entrada_Salida;
      //historialEncontrado.Id_Cliente= Historial.Id_Cliente;


      _appContext.SaveChanges();
    }
       return historialEncontrado; 
    }

    }

}