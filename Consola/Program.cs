using System;
using Dominio;
using TallerMecanica;
using TallerMecanica.Persistencia;

namespace Consola
{
    class Program
    {
        private static IRepositorioTecnico _RepoT = new RepositorioTecnico(new ApppContext());
        static void Main(string[] args)
        {
            ObtenerTecnicos();
           // AdicionarTecnico();
           //EliminarTecnico(2);
            /*Tecnico t = new Tecnico();
            t.Nombres = "Juan";
            t.Apellidos = "Jaramillo Mena";
            t.Ced = 34;
            t.NumeroTel = 3225914053;
            t.genero = "Masculino";
            _RepoT.AddTecnico(t);*/

            // Console.WriteLine("Hello World!");
        }

        private static void EliminarTecnico(int IdTecnico)
        {
            _RepoT.DeleteTecnico(IdTecnico);
            Console.WriteLine("**************");

        }

        private static void AdicionarTecnico()
        {
            Tecnico t = new Tecnico();
            t.Nombres = "Jhon";
            t.Apellidos = "Jara Mora";
            t.Ced = 32;
            t.NumeroTel = "3215914053";
            t.genero = "Masculino";
            _RepoT.AddTecnico(t);
            Console.WriteLine("Hello World!");
        }
        private static void ObtenerTecnicos()
        {
            var tecnicos = _RepoT.GetAllTecnico();
            foreach (var tecnico in tecnicos)
            {
                Console.WriteLine("El nombre es:" + tecnico.Nombres);
                Console.WriteLine("El nombre es:" + tecnico.Apellidos);
                Console.WriteLine("......................");

            }

            


        }


    }

}
