using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaCore.Interfaces
{
    public interface ICiudad
    {
        //1-3445672832 : Complain numbert Tikona 
        void Add(Ciudades b);
        void Edit(Ciudades b);
        void Remove(int CiudadesID);
        IEnumerable<Ciudades> GetCiudades();
        Ciudades FindById(int CiudadesID);
    }
}
