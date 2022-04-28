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
        public class Pedido
        {
            public int CodPedido;
            public string Cliente;
            public double Valor;
        }
        static void Main(string[] args)
        {
            var pedidos = new Dictionary<int, Pedido>();
            var p1 = new Pedido() { CodPedido = 1, Cliente = "Vinicius", Valor = 4000 };
            var p2 = new Pedido() { CodPedido = 2, Cliente = "Mayanne", Valor = 4500 };
            var p3 = new Pedido() { CodPedido = 3, Cliente = "Simba", Valor = 400 };

            pedidos.Add(1, p1);
            pedidos.Add(2, p2);
            pedidos.Add(3, p3);
            Console.WriteLine("Nomes dos clientes que fizeram pedidos: ");
            foreach (Pedido p in pedidos.Values)
            {
                Console.WriteLine(p.Cliente);
            }

            Console.WriteLine("Pedidos:");
            foreach (KeyValuePair<int, Pedido> kvp in pedidos)
            {
                Console.WriteLine($"{kvp.Key} = {kvp.Value.Cliente}");
            }

            Console.WriteLine($"Soma dos pedidos: {pedidos.Sum(p => p.Value.Valor)}");
        }

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;
            PosicaoClass pos2 = new PosicaoClass();
            pos2.X = 30;
            pos2.Y = 40;
            pos2 = pos1; // apontando ambos para a mesma posição de memória
            pos2.X = 50;

            pos1.Dobrar(pos1);
            pos2.Dobrar(pos2);
            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);
        }

        private static void ValueTypeInt()
        {
            int x = 10;
            int y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}