using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Carro : Veiculo
    {
        public string CorVeiculo { get; set; }
        public Carro(string corVeiculo = "Branco")
        {
            this.CorVeiculo = corVeiculo;
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
