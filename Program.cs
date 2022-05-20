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
            getPropriedades(t);
            Console.ReadLine();


            //EXEMPLO 2: Referencia a partir de uma string
            // Type t = Type.GetType("Reflexao.Carro", false, true);
            // Console.WriteLine(t.FullName);
            // Console.ReadLine();


            // EXEMPLO 1: Referencia direta a partir das propriedades do tipo pesquisado
            // Carro c = new Carro();
            // Type t = c.GetType();
            // Console.WriteLine(t.FullName);
            // Console.ReadLine();
        }

        private static void getPropriedades(Type t)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Informações do tipo: {t.Name}");
            str.AppendLine($"Nome completo: {t.FullName}");
            str.AppendLine($"Namespace: {t.Name}");

            Type tBase = t.BaseType;

            if(tBase != null) 
            {
                str.AppendLine($"Tipo Base: {t.BaseType.Name}");
            }

            MemberInfo[] members = t.GetMembers();

            foreach (var m in members)
            {
                str.AppendLine(m.MemberType + " " + m.Name);
            }

            Console.WriteLine(str);
        }
    }
}