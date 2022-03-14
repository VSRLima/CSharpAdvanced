using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CsharpAdvanced;

namespace ValueRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var prods = new Produtos();
            prods.Add("MT 03");
            prods.Add("R3");
            prods.Add("NINJA");
            Console.WriteLine(prods[0]);
            Console.WriteLine(prods[1]);
            Console.WriteLine(prods[2]);
            Console.WriteLine("A posição da moto MT 03 é: " + prods["MT 03"]);
            Console.ReadLine();
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