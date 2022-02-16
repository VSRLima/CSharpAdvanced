using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
    public class Dialogo
    {
        public void Show(DialogParams parameters)
        {
            //...
        }
    }

    public class DialogParams
    {
        public string Mensagem;
        public bool MostrarBotaoOK;
        public bool MostrarBotaoNO;
        public bool MostrarBotaoCancel;
        public int Delay;
        public bool Modal;
    }
}