using CapaDominioModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCore.Interfaces
{
    public interface IPais
    {
        //1-3445672832 : Complain numbert Tikona 
        void Add(Pais b);
        void Edit(Pais b);
        void Remove(int PaisID);
        IEnumerable<Pais> GetPais();
        Pais FindById(int PaisID);
    }
}
