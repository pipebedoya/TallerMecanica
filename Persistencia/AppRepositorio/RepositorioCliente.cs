using System.Collections.Generic;
using System;
using System.Linq; 
using Dominio;
using TallerMecanica.Persistencia;
using System.Threading.Tasks;

namespace TallerMecanica.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
      private readonly ApppContext _appContext; 
      public RepositorioCliente(ApppContext appContext)
          {
               _appContext = appContext;
          }

      Cliente IRepositorioCliente.AddCliente(Cliente cliente) 
    {
        var clienteAdicionado=_appContext.clientes.Add(cliente);
       _appContext.SaveChanges();
       return clienteAdicionado.Entity;
    }

    void IRepositorioCliente.DeleteCliente(int Idcliente){

        var clienteEncontrado=_appContext.clientes.FirstOrDefault(c=> c.Id == Idcliente);
        if (clienteEncontrado == null)
            return;
        _appContext.clientes.Remove(clienteEncontrado);
        _appContext.SaveChanges();
    }

  
    IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
    {
       return _appContext.clientes;
    }

    Cliente IRepositorioCliente.GetCliente(int Id_Cliente)
    {
      return _appContext.clientes.FirstOrDefault(c=> c.Id == Id_Cliente);
    }

    Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
    {
    var ClienteEncontrado=_appContext.clientes.FirstOrDefault(c=> c.Id == cliente.Id);
    if(ClienteEncontrado!= null)
    { 
       ClienteEncontrado.Nombre= cliente.Nombre;
       ClienteEncontrado.Apellido= cliente.Apellido;
       ClienteEncontrado.Cedula= cliente.Cedula;
       ClienteEncontrado.Direccion= cliente.Direccion;
       ClienteEncontrado.NumeroTelefono= cliente.NumeroTelefono;

      _appContext.SaveChanges();
    }
       return ClienteEncontrado; 
    }

    }

}