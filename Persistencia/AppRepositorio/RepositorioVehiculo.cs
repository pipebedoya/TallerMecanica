using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using SystemAcl.linq;
using System.Threading.Tasks;

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


<<<<<<< HEAD
       /* Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo Vehiculo);
=======
        /*Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo Vehiculo);
>>>>>>> 981daf5163f9e23acecc35f123e78c8c3e0755bf
        {throw new System.NotimplementedException();}
        void IRepositorio.DeleteVehiculo(int Id_Vehiculo );
        {throw new System.NotimplementedException();}
        Vehiculo IRepositorio.GetVehiculo(int Id_Vehiculo);
        {throw new System.NotimplementedException();}
        */

    }



}