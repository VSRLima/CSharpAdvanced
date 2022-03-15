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
            Arquivo mp3 = new Musica() { Nome = "Mirrors - Justin TimberLake"};
            Arquivo doc = new DocumentoWord() { Nome = ".net Magazine - Artigo POO"};
            Arquivo img = new Imagem() { Nome = "Golden Gate Bridge"};
            Windows windows = new Windows();

            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);
            
            windows.Abrir(mp3);
            windows.Abrir(doc);
            windows.Abrir(img);
            Console.WriteLine();
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