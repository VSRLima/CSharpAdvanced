using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CsharpAdvanced;
using System.Data.SqlClient;
using System.Collections;

namespace ValueRef
{
    class Program
    {
        public class Documento
        {
            public int Codigo;
            public string? Tipo;
            public string? Nome;
        }
        static void Main(string[] args)
        {
            var d1 = new Documento() { Codigo = 1, Nome = "Planilha", Tipo = "xls"};
            var d2 = new Documento() { Codigo = 2, Nome = "Artigo", Tipo = "doc"};
            var d3 = new Documento() { Codigo = 3, Nome = "Apresentação", Tipo = "ppt"};
            var pilha = new Stack<Documento>();
            pilha.Push(d1);
            pilha.Push(d2);
            pilha.Push(d3);
            Console.WriteLine(pilha.Count);
            var obj = pilha.Pop();
            Console.WriteLine(obj?.Nome);

            Console.WriteLine(pilha?.Peek().Nome);

            while(pilha.Count > 0)
                Console.WriteLine(pilha.Pop().Nome);
        }

    }
}