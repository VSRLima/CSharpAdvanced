﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef
{
    public class PosicaoClass // reference type
    {
        public int X;
        public int Y;
    }

    class Program
    {
        public static void Dobrar (ref int valor) //ref == utiliza-lo como um valor de referencia.
        {
            valor = valor * 2;
        }

        public static void Dobrar (PosicaoClass valor) //ref == utiliza-lo como um valor de referencia.
        {
            valor.X = valor.X * 2;
            valor.Y = valor.Y * 2;
        }

        static void Main(string[] args)
        {
            int x = 10;
            Dobrar(ref x);
            Console.WriteLine(x);

            RefTypeInt();
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

            Dobrar(pos1);
            Dobrar(pos2);
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