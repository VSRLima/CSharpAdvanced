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
            Console.WriteLine("Login: ");
            string? user = Console.ReadLine();
            Console.WriteLine("Senha: ");
            string? password = Console.ReadLine();

            try
            {
                Auth.Login(user, password);
            }
            catch (InvalidUserException ie)
            { 
                Console.WriteLine(ie.Message);
            }
            catch (InvalidPasswordException ip)
            {
                Console.WriteLine(ip.Message);
            }
            
            return;
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