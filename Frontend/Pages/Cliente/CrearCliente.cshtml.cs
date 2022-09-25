using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using TallerMecanica.Persistencia;


namespace Frontend.Pages
{
    public class CrearClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente {get;set;}
        public CrearClienteModel(IRepositorioCliente repositorioC)
        {
            _repo= repositorioC;
        }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost(Cliente cliente)
        {
            _repo.AddCliente(cliente);
            return new RedirectToPageResult("/Cliente/MostrarListadoCliente");
        }
    }
}
