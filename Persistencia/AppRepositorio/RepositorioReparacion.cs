using System.Collections.Generic;
using System.Linq; 
using Dominio;

namespace TallerMecanica.Persistencia
{
    public class RepositorioReparacion : IRepositorioReparacion
    {
      
     private readonly ApppContext _appContext; 
     public RepositorioReparacion(ApppContext appContext)
          {
               _appContext = appContext;
          }

    Reparacion IRepositorioReparacion.AddReparacion (Reparacion reparacion) 
    {
        var reparacionAdicionado=_appContext.Add(reparacion);
       _appContext.SaveChanges();
       return reparacionAdicionado.Entity;
    }

    void IRepositorioReparacion.DeleteReparacion(int Id_Reparacion){

        var reparacionEncontrado=_appContext.reparaciones.FirstOrDefault(r=> r.Id == Id_Reparacion);
        if (reparacionEncontrado == null)
            return;
        _appContext.Remove(reparacionEncontrado);
        _appContext.SaveChanges();
    }

  
    IEnumerable<Reparacion> IRepositorioReparacion.GetAllReparacion()
    {
       return _appContext.reparaciones;
    }

    Reparacion IRepositorioReparacion.GetReparacion(int Id_Reparacion)
    {
      return _appContext.reparaciones.FirstOrDefault(r=> r.Id == Id_Reparacion);
    }

    Reparacion IRepositorioReparacion.UpdateReparacion(Reparacion reparacion)
    {
    var reparacionEncontrado=_appContext.reparaciones.FirstOrDefault(r=> r.Id == reparacion.Id);
    if(reparacionEncontrado!= null)
    { 
      //reparacionEncontrado.Id = reparacion.Id;
      //reparacionEncontrado.Id_Tecnico= Reparacion.Id_Tecnico;
      //reparacionEncontrado.Repuestos= Reparacion.Repuestos;
      //reparacionEncontrado.Id_historial= Reparacion.Id_historial;

      _appContext.SaveChanges();
    }
       return reparacionEncontrado; 
    }

    }
}