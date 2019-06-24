using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Moto : Veiculo
    {
        public int QuantidadeRodas { get; set; }

        public Moto(int quantidadeRodas=2)
        {
            this.QuantidadeRodas = quantidadeRodas;
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
