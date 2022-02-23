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
        void Delete(int index);
        Node<T> Find(int index);
        void Edit(int index, Node<T> model);
        
    }
}
