using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
   public class DentistaRep
    {
        public void Cadastrar(Dentista obj)
        {
            using(var ctx = new SistemaContext())
            {
                ctx.Dentistas.Add(obj);
                ctx.SaveChanges();
            }

            
        }


        public Dentista Buscar(int id)
        {
            Dentista obj = new Dentista();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Dentistas.Find(id);
            }
            return obj;
        }


        public List<Dentista> Listar()
        {
            
            using (var ctx = new SistemaContext())
            {
                var Dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Nome).ToList();
                return Dentistas;
            }
           
        }


        public void Deletar(int id)
        {
            using(var ctx = new SistemaContext())
            {
                Dentista obj = ctx.Dentistas.Find(id);
                ctx.Dentistas.Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Dentista objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista objAntigo = ctx.Dentistas.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.Telefone = objNovo.Telefone;
                objAntigo.Celular = objNovo.Celular;
                objAntigo.CRO = objNovo.CRO;
                objAntigo.Email = objNovo.Email;
                ctx.SaveChanges();
            }
        }
    }
}
