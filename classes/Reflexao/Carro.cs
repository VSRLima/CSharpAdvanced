using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexao
{
    class Carro : ICarro
    {
        public string? Cor {get; set;}
        public int Velocidade {get; set;}

        public Carro()
        {
            this.Cor = "Vermelho";
            this.Velocidade = 0;
        }

        public Carro(string cor, int velocidade)
        {
            this.Cor = cor;
            this.Velocidade = velocidade;
        }

        public void Acelerar(int qntd)
        {
            this.Velocidade += qntd;
        }

        public bool isMoving() 
        {
            if(this.Velocidade == 0)
                return false;
            
            return true;
        }

        public double CalcularKmPorL(int kmInicial, int kmFinal, double litros)
        {
            return (kmFinal - kmInicial) / litros;
        }
    }

    internal class CarroSport: Carro
    {
        public CarroSport()
        {
            Cor = "Azul";
        }
    }
}