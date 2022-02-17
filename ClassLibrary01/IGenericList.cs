using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary01
{
    interface IGenericList<T>
    {
        bool Insert(T newElement);
        bool Delete(int index);

    }
}
