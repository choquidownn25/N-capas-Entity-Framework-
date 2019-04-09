using CapaCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInfrastructura.Repositorios
{
    public class CiudadRepositorios : ICiudad
    {
        SigtiEntities context = new SigtiEntities();
        public void Add(Ciudades b)
        {
            context.Ciudades.Add(b);
            context.SaveChanges();
        }

        public void Edit(Ciudades b)
        {
            context.Entry(b).State = System.Data.Entity.EntityState.Modified;

        }

        public Ciudades FindById(int CiudadesID)
        {
            var ciudades = (from r in context.Ciudades where r.Id == CiudadesID select r).FirstOrDefault();
            return ciudades;
        }

        public IEnumerable<Ciudades> GetCiudades()
        {
            //return context.Ciudades.OrderBy(e => e.Id).ToList();
            return context.Ciudades;
        }

        public void Remove(int CiudadesID)
        {
            Ciudades b = context.Ciudades.Find(CiudadesID);
            context.Ciudades.Remove(b);
            context.SaveChanges();
        }
    }
}
