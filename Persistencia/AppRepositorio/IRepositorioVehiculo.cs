using System.Collections.Generic;
using Dominio;


namespace TallerMecanica.Persistencia
{
    public interface IRepositorioVehiculo
    {
    
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(vehiculo vehiculo);
<<<<<<< HEAD
        Vehiculo UpdateVehiculo(Vehicuo Vehiculo);
=======
        /*Vehiculo UpdateVehiculo(Vehicuo Vehiculo);
>>>>>>> 981daf5163f9e23acecc35f123e78c8c3e0755bf
        void DeleteVehiculo(int Id_Vehiculo);
        Vehiculo GetVehiculo(int Id_Vehiculo);



       /* IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo Vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo Vehiculo);
        void DeleteVehiculo(int Id_Vehiculo );
        Vehiculo GetVehiculo(int Id_Vehiculo);*/

    }


}