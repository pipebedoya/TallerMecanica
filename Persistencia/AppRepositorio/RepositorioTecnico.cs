using System.Transactions;
using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;


namespace TallerMecanica.Persistencia
{
    public class RepositorioTecnico : IRepositorioTecnico
    {
          private readonly ApppContext _appContext;
          public RepositorioTecnico(ApppContext appContext)
          {
               _appContext = appContext;
          }
           // public RepositorioTecnico(){}
            
            Tecnico IRepositorioTecnico.AddTecnico(Tecnico tecnico)          
            {
              var new_tecnico = _appContext.tecnicos.Add(tecnico);
              _appContext.SaveChanges();
              return new_tecnico.Entity;
            }

            void IRepositorioTecnico.DeleteTecnico(int Id_Tecnico)
            {
              var TecnicoEncontrado = _appContext.tecnicos.FirstOrDefault(t => t.Id == Id_Tecnico);
              if(TecnicoEncontrado == null)
              return;
              _appContext.Remove(TecnicoEncontrado);
              _appContext.SaveChanges();

            }
            
            IEnumerable<Tecnico> IRepositorioTecnico.GetAllTecnico()
            {
              return _appContext.tecnicos;
            }

            Tecnico IRepositorioTecnico.GetTecnico(int Id_Tecnico)
            {
              return _appContext.tecnicos.FirstOrDefault(t => t.Id == Id_Tecnico);
              
            }

            Tecnico IRepositorioTecnico.UpdateTecnico(Tecnico tecnico)
            {
              var TecnicoEncontrado = _appContext.tecnicos.FirstOrDefault(t => t.Id == tecnico.Id);
              if(TecnicoEncontrado != null)
              {
                TecnicoEncontrado.Nombres = tecnico.Nombres;
                TecnicoEncontrado.Apellidos = tecnico.Apellidos;
                TecnicoEncontrado.Ced = tecnico.Ced;
                TecnicoEncontrado.NumeroTel = tecnico.NumeroTel;
                TecnicoEncontrado.genero = tecnico.genero;
              }
              _appContext.SaveChanges();
              return TecnicoEncontrado;
            }


        
    }



}