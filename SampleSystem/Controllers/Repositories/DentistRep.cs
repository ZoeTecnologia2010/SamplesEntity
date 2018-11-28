using Controllers.Context;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
   public class DentistRep
    {
        public void Cadastrar(Dentist obj)
        {
            using(var ctx = new SystemContext())
            {
                ctx.Dentists.Add(obj);
                ctx.SaveChanges();
            }

            
        }


        public Dentist Buscar(int id)
        {
            Dentist obj = new Dentist();
            using (var ctx = new SystemContext())
            {
                obj = ctx.Dentists.Find(id);
            }
            return obj;
        }


        public List<Dentist> Listar()
        {
            
            using (var ctx = new SystemContext())
            {
                var Dentists = (from obj in ctx.Dentists select obj).OrderBy(x => x.Name).ToList();
                return Dentists;
            }
           
        }


        public void Deletar(int id)
        {
            using(var ctx = new SystemContext())
            {
                Dentist obj = ctx.Dentists.Find(id);
                ctx.Dentists.Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Dentist objNovo)
        {
            using (var ctx = new SystemContext())
            {
                Dentist objAntigo = ctx.Dentists.Find(objNovo.Id);
                objAntigo.Name = objNovo.Name;
                objAntigo.Phone = objNovo.Phone;
                objAntigo.Cellphone = objNovo.Cellphone;
                objAntigo.Number = objNovo.Number;
                objAntigo.Email = objNovo.Email;
                ctx.SaveChanges();
            }
        }
    }
}
