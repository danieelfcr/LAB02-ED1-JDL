using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary01
{
    interface IGenericList<T>
    {
        void Insert(Node<T> Node);
        bool Delete(int index);
        //object Find(Func<T, bool> p);
    }
}
