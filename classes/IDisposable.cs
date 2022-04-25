using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CsharpAdvanced
{
    public static class Conexao: IDisposable 
    {
        public int Handle;

        public Conexao() 
        {
            this.Handle = "Recurso alocado";
            Console.WriteLine("Recurso alocado com sucesso");
        }

        public void Connect()
        {
            Console.WriteLine("Conectado");
        }

        public void Close()
        {
            Console.WriteLine("Desconectado");
        }

        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize();
        }

        private void OpenResource()
        {
            Handle = "";
            Console.WriteLine("Recurso liberado com sucesso");
        }

        public virtual void Dispose(bool disposing)
        {
            if(disposing) 
            {
                //releasing managed resources
            }
            // Releasing unmanaged resources
            OpenResource();
        }
    }
}