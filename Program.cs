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
            PosicaoClass pc = new PosicaoClass();
            pc.X = 10;
            pc.Y = 20;

            PosicaoStruct ps = new PosicaoStruct();
            ps.X = 30;
            ps.Y = 40;
            
            PosicaoStruct ps2 = ps;
            ps2.Y = 50;

            Console.WriteLine(pc);
            Console.WriteLine(ps.ToString());
            Console.WriteLine(ps2.ToString());
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