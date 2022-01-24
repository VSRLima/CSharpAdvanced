using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAdvanced;

namespace ValueRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.codigoCliente = 123;
            cli.Nome = "Vinicius";
            cli.Contato.Tipo = "Telefone";
            cli.Contato.Descricao = "99999999";
            Console.WriteLine(cli);

            Cliente cli2 = new Cliente(456);
            cli2.Nome = "Vinicius 2";
            cli2.Contato.Tipo = "Telefone";
            cli2.Contato.Descricao = "99999999";
            Console.WriteLine(cli2);

            Cliente cli3 = new Cliente(789, "sla");
            cli3.Contato.Tipo = "Telefone";
            cli3.Contato.Descricao = "99999999";
            Console.WriteLine(cli3);
            
            ClienteVIP  cliVIP = new ClienteVIP(901, "teste");
            Console.WriteLine(cliVIP);
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