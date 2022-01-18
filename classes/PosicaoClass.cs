using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
    public class PosicaoClass  // reference type
    {
        public int X;
        public int Y;
        
        public void Dobrar (ref int valor) //ref == utiliza-lo como um valor de referencia.
        {
            valor = valor * 2;
        }

        public  void Dobrar (PosicaoClass valor) 
        {
            valor.X = valor.X * 2;
            valor.Y = valor.Y * 2;
        }

        public override string ToString() 
        { 
            return "X = " + X.ToString() + ", Y = " + Y.ToString();
        }
    }
}

