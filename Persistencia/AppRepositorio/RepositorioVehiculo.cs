using System.Collections.Generic;
using System.Linq; 
using Dominio;

namespace TallerMecanica.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
      private readonly ApppContext _appContext;
      public RepositorioVehiculo(ApppContext appContext)
          {
               _appContext = appContext;
          }

      Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo) 
    {
        var vehiculoAdicionado=_appContext.vehiculos.Add(vehiculo);
       _appContext.SaveChanges();
       return vehiculoAdicionado.Entity;
    }

    void IRepositorioVehiculo.DeleteVehiculo(int Id_Vehiculo)
    {

        var vehiculoEncontrado=_appContext.vehiculos.FirstOrDefault(v=> v.Id == Id_Vehiculo);
        if (vehiculoEncontrado == null)
            return;
        _appContext.vehiculos.Remove(vehiculoEncontrado);
        _appContext.SaveChanges();
    }

  
    IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos()
    {
       return _appContext.vehiculos;
    }

    Vehiculo IRepositorioVehiculo.GetVehiculo(int Id_Vehiculo)
    {
      return _appContext.vehiculos.FirstOrDefault(v=> v.Id == Id_Vehiculo);
    }

    Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo vehiculo)
    {
    var vehiculoEncontrado=_appContext.vehiculos.FirstOrDefault(v=> v.Id == vehiculo.Id);
    if(vehiculoEncontrado!= null)
    { 
       vehiculoEncontrado.Id=vehiculo.Id;
       vehiculoEncontrado.Numero_Placa=vehiculo.Numero_Placa;
       vehiculoEncontrado.Modelo=vehiculo.Modelo;
       vehiculoEncontrado.Color=vehiculo.Color;
       vehiculoEncontrado.Cilindraje=vehiculo.Cilindraje;

      _appContext.SaveChanges();
    }
       return vehiculoEncontrado; 
    }

    }
}