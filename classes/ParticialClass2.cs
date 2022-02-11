using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

public partial class Usuario
{
    public bool Auth()
    {
        return ((this.Nome == "vinicius") & (this.Senha == "123"));
    }
}