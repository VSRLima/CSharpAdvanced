using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{

    public class Filme
    {
        public int Ano;
        public string Nome;
    }

    public class Ator
    {
        public int Codigo;
        public string Nome;
        public List<Filme> Filme;
    }
}
