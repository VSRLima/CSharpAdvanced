using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }
    public class Cliente
    {
        public int codigoCliente;
        public string Nome;
        public Contato Contato;

        //Default
        public Cliente()
        {
            this.Contato = new Contato();
            this.Nome = "sem nome";
            this.codigoCliente = 0;
        }

        //Overload
        public Cliente(int codigo)
        {
            this.Contato = new Contato();
            this.codigoCliente = codigo;
        }

        public Cliente(int codigo, string nome)
        {
            this.Contato = new Contato();
            this.codigoCliente = codigo;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return "Código: " + codigoCliente + " , Nome: " + Nome;
        }
    }

    //Doesn't receive constructor methods from his father, because constructos are static methods
    public class ClienteVIP : Cliente
    {
        public int Tempo;
        public ClienteVIP(int codigo, string nome) :base(codigo,nome)//Calling constructor from base class, so it's like a type of heritage for constructors
        {
            this.Tempo = 10;
        }
    }
}