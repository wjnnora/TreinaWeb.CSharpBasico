using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public sealed class Carro : Veiculo
    {
        public string CorVeiculo { get; set; }
        public Carro(string nome, string marca, double potencia = 1.0, string corVeiculo = "Branco")
        {
            base.Nome = nome;
            base.Marca = marca;
            base.Potencia = potencia;
            this.CorVeiculo = corVeiculo;
        }

        public override string Ligar()
        {
            return string.Format("O carro de nome {0}, marca {1} está ligado.", this.Nome, this.Marca);
        }

        public override string Desligar()
        {
            return string.Format("O carro de nome {0}, marca {1} está desligado.", this.Nome, this.Marca);
        }

        public override void Abastecer(double quantidade)
        {
            this.QuantidadeCombustivel += quantidade;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\n");
            sb.Append("Cor do Veiculo: " + this.CorVeiculo);
            return sb.ToString();
        }
    }
}
