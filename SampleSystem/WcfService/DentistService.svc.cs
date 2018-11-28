using Controllers.Repositorios;
using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    public class DentistService : IDentist
    {
        private DentistRep rep = new DentistRep();
        
        public void Cadastrar(Dentist obj)
        {
            rep.Cadastrar(obj);
        }

        public Dentist Buscar(int id)
        {
            return rep.Buscar(id);
        }
        
        public List<Dentist> Listar()
        {
            return rep.Listar();
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Dentist objNovo)
        {
            rep.Editar(objNovo);
        }
    }
}
