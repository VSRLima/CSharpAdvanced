using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexao
{
    public class Cliente
    {
        public string Nome {get; set;}
        
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public void MostrarDados(string titulo)
        {
            Console.WriteLine("Nome: {0} // Titulo: {1}", this.Nome, titulo);
        }
    }
}