using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using TallerMecanica.Persistencia;

//namespace MyApp.Namespace
namespace Frontend.Pages
{
    public class MostrarListadoClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repos;
        public IEnumerable<Cliente> Clientes{get;set;}
        public MostrarListadoClienteModel(IRepositorioCliente repositorioC)
        {
            _repos= repositorioC;
        }
        public void OnGet()
        {
            Clientes= _repos.GetAllClientes();
            foreach(var cliente in Clientes )
            {
                //Console.WriteLine(cliente.Nombre);
            }
        }
    }
}
