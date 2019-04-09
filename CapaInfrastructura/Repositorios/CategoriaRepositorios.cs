using CapaCore.Interfaces;
using CapaDominioModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInfrastructura.Repositorios
{
    public class CategoriaRepositorios : ICategoria
    {
        SigtiEntities context = new SigtiEntities();

        public CategoriaRepositorios()
        {
        }

        public void Add(Categoria b)
        {

            IList<Categoria> newCategoria = new List<Categoria>()
            {
            new Categoria() { Codigo = b.Codigo },
            new Categoria() { Nombre = b.Nombre },
            new Categoria() { Descripcion = b.Descripcion },
            new Categoria() { Activo = b.Activo }
            };

            Categoria categoria = new Categoria
            {
                Codigo = b.Codigo,
                Nombre = b.Nombre,
                Descripcion = b.Descripcion,
                Activo = b.Activo

            };

            context.Categoria.Add(categoria);
            context.SaveChanges();
        }

        public void Edit(Categoria b)
        {
            context.Entry(b).State = System.Data.Entity.EntityState.Modified;
        }

        public Categoria FindById(int CategoriaID)
        {
            var categoria = (from r in context.Categoria where r.id == CategoriaID select r).FirstOrDefault();
            return categoria;
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            try
            {
                List<Categoria> lstObj = new List<Categoria>();
                var result = (from item in context.Categoria
                              select new
                              {
                                  item.Activo,
                                  item.Descripcion,
                                  item.Nombre,
                                  item.Codigo,
                                  item.id,
                              }).ToList();

                foreach (var item in result)
                {
                    Categoria item1 = new Categoria();

                    item1.id = item.id;
                    item1.Codigo = item.Codigo;
                    item1.Nombre = item.Nombre;
                    item1.Descripcion = item.Descripcion;
                    item1.Activo = item.Activo;


                    lstObj.Add(item1);
                }


                //return context.Categorias.OrderBy(e => e.id).ToList();
                return lstObj;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw ;
                
            }
            
        }

        public void Remove(int CategoriaID)
        {
            Categoria b = context.Categoria.Find(CategoriaID);
            context.Categoria.Remove(b);
            context.SaveChanges();
        }
    }
}
