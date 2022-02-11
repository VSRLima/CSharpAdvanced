using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CsharpAdvanced
{
    public class Pilha<T>
    {
        int pos = 0;
        T[] itens = new T[100];
        
        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }

        public T Pop()
        {
            pos--;
            return itens[pos];
        }
    }
}