using CapaCore.Interfaces;
using CapaDominioModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInfrastructura.Repositorios
{
    public class PaisRepository : IPais
    {
        SigtiEntities context = new SigtiEntities();

        public PaisRepository()
        {
        }

        public void Add(Pais b)
        {
            context.Pais.Add(b);
            context.SaveChanges();
        }

        public void Edit(Pais b)
        {
            context.Entry(b).State = System.Data.Entity.EntityState.Modified;

        }

        public Pais FindById(int PaisID)
        {
            var pais = (from r in context.Pais where r.Id == PaisID select r).FirstOrDefault();
            return pais;
        }

        public IEnumerable<Pais> GetPais()
        {
            return context.Pais;
        }

        public void Remove(int PaisID)
        {
            Pais b = context.Pais.Find(PaisID);
            context.Pais.Remove(b);
            context.SaveChanges();
        }
    }
}
