using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Potencia { get; set; }
        public double QuantidadeCombustivel { get; set; }

        public Veiculo()
        {
            this.Nome = "Sem Nome";
            this.Marca = "Sem Marca";
            this.Potencia = 0;
            this.QuantidadeCombustivel = 0;
        }

        public Veiculo(string nome, string marca, double potencia, double quantidadeCombustivel)
        {
            this.Nome = nome;
            this.Marca = marca;
            this.Potencia = potencia;
            this.QuantidadeCombustivel = quantidadeCombustivel;
        }

        public void Ligar()
        {
            Console.WriteLine("O veículo {0} da marca {1} está ligado.", this.Nome, this.Marca);
        }

        public void Desligar()
        {
            Console.WriteLine("O veículo {0} da marca {1} está desligado.", this.Nome, this.Marca);
        }

        public void Abastecer(double quantidadeCombustivel)
        {
            this.QuantidadeCombustivel = quantidadeCombustivel;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nome: " + this.Nome);
            sb.Append("\n");
            sb.Append("Marca: " + this.Marca);
            sb.Append("\n");
            sb.Append("Potência: " + this.Potencia);
            sb.Append("\n");
            sb.Append("Quantidade combustível: " + this.QuantidadeCombustivel);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Veiculo veiculo = (Veiculo)obj;
            return veiculo.Nome == this.Nome;
        }
    }
}
