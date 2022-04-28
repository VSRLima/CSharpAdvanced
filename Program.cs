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
        public class Correntista
        {
            public string? Agencia;
            public string? Conta;
            public string? Nome;

            public override string ToString()
            {
                return $"Agência: {Agencia} // Conta: {Conta} // Nome: {Nome} ";
            }
        }
        static void Main(string[] args)
        {
            var p1 = new Correntista() { Agencia = "123", Conta = "456", Nome = "Vinicius"};
            var p2 = new Correntista() { Agencia = "456", Conta = "123", Nome = "Mayanne"};
            var p3 = new Correntista() { Agencia = "789", Conta = "000", Nome = "Simba"};

            var fila = new Queue();
            fila.Enqueue(p1);
            fila.Enqueue(p2);
            fila.Enqueue(p3);

            Console.WriteLine("Correntistas aguardando na fila:");
            foreach (var f in fila)
            {
                Console.WriteLine(f);
            }

            
            while(fila.Count > 0)
            {
                    Console.WriteLine("Pressione uma tecla para chamar correntista:");
                    Console.ReadKey();
                    Console.WriteLine($"Chamando: {fila.Dequeue()}");
            }
            Console.WriteLine("Fila vazia");
        }
        
    }
}