using CapaDominioModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCore.Interfaces
{
    public interface ICategoria
    {
        //1-3445672832 : Complain numbert Tikona 
        void Add(Categoria b);
        void Edit(Categoria b);
        void Remove(int CategoriaID);
        IEnumerable<Categoria> GetCategorias();
        Categoria FindById(int CategoriaID);
    }
}
