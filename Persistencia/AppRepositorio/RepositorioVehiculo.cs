using System;
/*using IRepositorioVehiculo;*/

namespace TallerMecanica.Persistencia
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {
        private readonly AppContext _appContext;

        public RepositorioVehiculo(AppContext appContext)
        {
               _appContext = appContext;
        }
        
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos();
        {
            throw new System.NotimplementedException();
        }
        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo Vehiculo);
        {
            
        }


        /*Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo Vehiculo);
        {throw new System.NotimplementedException();}
        void IRepositorio.DeleteVehiculo(int Id_Vehiculo );
        {throw new System.NotimplementedException();}
        Vehiculo IRepositorio.GetVehiculo(int Id_Vehiculo);
        {throw new System.NotimplementedException();}
        */

    }



}