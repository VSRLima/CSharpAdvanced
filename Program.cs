using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CsharpAdvanced;
using System.Data.SqlClient;
using System.Collections;
using Reflexao;
using System.Reflection;

namespace ValueRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Carro);
            GetParametros(t);
            Console.ReadLine();
        }

        private static void GetParametros(Type t)
        {
            Console.WriteLine("Parâmetros do tipo {0}", t.Name);
            MethodInfo[] metodos = t.GetMethods();
            foreach (var m in metodos)
            {
                string resultado = m.ReturnType.FullName;
                StringBuilder str = new StringBuilder();
                foreach (ParameterInfo pi in m.GetParameters())
                {
                    str.Append(pi.ParameterType.FullName);
                    str.Append(" ");
                    str.Append(pi.Name);
                    str.Append(", ");
                }
                Console.WriteLine("{0} {1}({2})", resultado, m.Name, str.ToString().TrimEnd(',', ' '));
            }
        }

        private static void GetInterfaces(Type t)
        {
            Console.WriteLine("Interfaces do tipo {0}", t.Name);
            foreach (Type i in t.GetInterfaces())
            {
                Console.WriteLine("\t{0}", i.Name);
            }
        }

        private static void GetPropriedades(Type t)
        {
            Console.WriteLine("Propriedades:");
            PropertyInfo[] propriedades = t.GetProperties();
            foreach (PropertyInfo propriedade in propriedades)
            {
                Console.WriteLine(propriedade.Name);
            }
        }

        private static void GetCampos(Type t)
        {
            Console.WriteLine("Campos: ");
            FieldInfo[] fields = t.GetFields();
            foreach (var f in fields)
            {
                Console.WriteLine(f.Name);
            }
        }

        private static void GetMetodo(Type t)
        {
            MethodInfo mi =  t.GetMethod("isMoving");
            Console.WriteLine(mi.Name);
        }

        private static void GetMetodos(Type t)
        {
            Console.WriteLine("Métodos: ");
            MethodInfo[] mi = t.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            foreach (var m in mi)
            {
                Console.WriteLine($"Método: {m.Name}");
            }
        }
    }
}