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
            _repo.GetCliente(id);
        }
    }
}
