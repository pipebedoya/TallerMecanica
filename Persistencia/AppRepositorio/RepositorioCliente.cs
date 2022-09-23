using System.Collections.Generic;
using System.Linq; 
using Dominio;

namespace TallerMecanica.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
      private readonly AppContext _appContext; 

      CLiente IRepositorioCliente.AddCliente (Cliente cliente) 
    {
        var clienteAdicionado=_appcontext.Clientes.Add(cliente);
       _appcontext.Savechanges();
       return clienteAdicionado.Entity;
    }

    void IRepositorioCliente.DeleteCliente(Cliente cliente){

        var clienteEncontrado=_appContex.Clientes.FirstOrDefault(c=> c.Id == Id_Cliente);
        if (clienteEncontrado == null)
            return;
        _appContex.Clientes.Remove(clienteEncontrado);
        _appContex.Savechanges();
    }

  
    IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
    {
       return _appContex.Clientes;
    }

    Cliente IRepositorioCliente.GetCliente(int Id_Cliente)
    {
      return _appContex.Clientes.FirstOrDefault(c=> c.Id == Id_Cliente);
    }

    Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
    {
    var clienteEncontrado=_appContex.Clientes.FirstOrDefault(c=> c.Id == Cliente.Id);
    if(clienteEncontrado!= null)
    { 
       ClienteEncontrado.Id_Nombre=Cliente.Nombre_Id;
       ClienteEncontrado.Apellidos=Cliente.Apellidos;
       ClienteEncontrado.Cedula=Cliente.Cedula;
       ClienteEncontrado.Direccion=Cliente.Direccion;
       ClienteEncontrado.Telefono=Cliente.Telefono;

      _appContext.Savechanges();
    }
       return clienteEncontrado; 
    }

    }

}