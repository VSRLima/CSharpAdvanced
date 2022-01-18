using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
    public struct PosicaoStruct
    {
        public int X;
        public int Y;

        public string ToString() //Note que para que o sistema ao invés de escrever o tipo do objeto PosicaoStruct, e sim escrever a string concatenada como construida pelo metodo é preciso chamá-la, pois está não substitui o método inerente da classe base Object para sobrescrever o seu uso. Tanto que aparece uma mensagem de aviso a fazer tal ato. 
        {
            return "X = " + X.ToString() + ", Y = " + Y.ToString();
        }
    }
}

