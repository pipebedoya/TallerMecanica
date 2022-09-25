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
    public class DetallesClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente {get;set;}
        public DetallesClienteModel(IRepositorioCliente repoC)
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
            _repo.GetCliente(id);
            return new RedirectToPageResult("/Cliente/MostrarListadoCliente");
        }
    }
}
