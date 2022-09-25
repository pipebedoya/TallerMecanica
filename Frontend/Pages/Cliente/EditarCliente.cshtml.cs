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
    public class EditarClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente {get;set;}
        public EditarClienteModel(IRepositorioCliente repositorioC)
        {
            _repo= repositorioC;
        }
        
        public void OnGet(int id)
        {
             cliente= _repo.GetCliente(id);
        }
        public IActionResult OnPost(Cliente cliente)
        {
            _repo.UpdateCliente(cliente);
            return new RedirectToPageResult("/Cliente/MostrarListadoCliente");
        }
    }
}
