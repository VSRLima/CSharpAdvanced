using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace CsharpAdvanced
{

    public abstract class Arquivo
    {
        public string Nome;
        public int Tamanho;

        //Com abstract vc n precisa colocar um código comum a todos, já com o virtual sim. E com o virtual, para utilizar o código base, vc precisa chamar o base.
        public virtual void Abrir()
        {
            Console.WriteLine($"Abrindo arquivo {Nome}");
        }
    }

    public class Musica : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine("Tocando música" + Nome);
        }
    }

    public class DocumentoWord : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine("Mostrando documento do Word: " + Nome);
        }
    }

    public class Imagem : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine("Exibindo imagem:" + Nome);
        }
    }

    public class Windows
    {
        public List<Arquivo> arquivos;

        public Windows()
        {
            this.arquivos = new List<Arquivo>();
        }

        public void Add(Arquivo arquivo)
        {
            this.arquivos.Add(arquivo);
        }

        public void Abrir(Arquivo arquivo)
        {
            arquivo.Abrir();
        }
    }
}
