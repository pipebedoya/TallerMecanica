using System.Collections.Generic;
using Dominio;


namespace TallerMecanica.Persistencia
{
    public interface IRepositorioVehiculo
    {
    
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int Id_Vehiculo);
        Vehiculo GetVehiculo(int Id_Vehiculo);
    }


}