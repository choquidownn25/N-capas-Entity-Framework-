using System;
using System.Collections.Generic;
using System.Text;

namespace CapaService.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
