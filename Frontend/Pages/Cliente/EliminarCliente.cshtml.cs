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
    public class EliminarClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente {get;set;}
        public EliminarClienteModel(IRepositorioCliente repoC)
        {
            _repo= repoC;
        }
        public void OnGet(int id)
        {
            cliente=_repo.GetCliente(id);
            //Console.WriteLine(id);
        }
        public IActionResult OnPost(int id)
        {
            _repo.DeleteCliente(id);
            return new RedirectToPageResult("/Cliente/MostrarListadoCliente");
        }
    }
}
