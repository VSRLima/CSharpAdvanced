using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CsharpAdvanced
{
    public class Produtos
    {
        private List<string> _itens;

        public Produtos()
        {
            this._itens = new List<string>();
        }

        public void Add(string item)
        {
            this._itens.Add(item);
        }

        public string Get(int index)
        {
            return this._itens[index];
        }

        //Indexed Property
        public string this [int index]
        {
            get
            {
                return this._itens[index];
            }
        }

        public int this [string nome]
        {
            get
            {
                return this._itens.IndexOf(nome);
            }
        }
    }
}