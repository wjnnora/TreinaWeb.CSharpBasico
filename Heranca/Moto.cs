using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public sealed class Moto : Veiculo
    {
        public int QuantidadeRodas { get; set; }

        public Moto(int quantidadeRodas = 2)
        {
            this.QuantidadeRodas = quantidadeRodas;
        }

        public override string Ligar()
        {
            return string.Format("A moto de nome {0}, marca {1} está ligado.", base.Nome, base.Marca);
        }

        public override string Desligar()
        {
            return string.Format("A moto de nome {0}, marca {1} está desligado.", this.Nome, this.Marca);
        }

        public override string Abastecer()
        {
            return string.Format("A moto de nome {0}, marca {1} está abastecida.", this.Nome, this.Marca);
        }
        public override string Desabastecer()
        {
            return string.Format("A moto de nome {0}, marca {1} está desabastecido.", this.Nome, this.Marca);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("\n");
            sb.Append("Quantidade de Rodas: " + this.QuantidadeRodas);
            return sb.ToString();
        }            
    }
}
