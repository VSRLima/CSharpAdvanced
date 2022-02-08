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
            // STATIC VERSION
            // var temperatura = 35.0;
            // temperatura = ConversorStatic.CelsiusToFah(temperatura);
            // Console.WriteLine(temperatura);
            // Console.ReadLine();

            var c1 = new ConversorInstance();
            // As the property "Temperatura" is static, it can be instaciated as static only on the class, but if you want to call it, you'll have to call the object and it static propety as shown bellow: 
            ConversorInstance.temperatura = 30;
            var celcius = c1.CelsiusToFah();
            Console.WriteLine(celcius);

            var c2 = new ConversorInstance();
            ConversorInstance.temperatura = 35;
            var fah = c2.FahToCelsius();
            Console.WriteLine(fah);
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