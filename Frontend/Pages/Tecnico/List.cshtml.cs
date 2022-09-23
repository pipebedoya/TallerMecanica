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
    public class ListModel : PageModel
    {
        //private string[] saludos = {"1aa","ddd2","yyy"};
        //public List<string> ListaSaludos {get;set;}
        private readonly IRepositorioTecnico _repo;
        public IEnumerable<Tecnico> Tecnicos{get;set;}
        public ListModel(IRepositorioTecnico repositorioT)
        {
            _repo= repositorioT;
        }

        
        public void OnGet()

        {
            Tecnicos= _repo.GetAllTecnico();
            foreach(var tecnico in Tecnicos )
            {
                Console.WriteLine(tecnico.Nombres);
            }
           // ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(saludos);
        }
    }
}
