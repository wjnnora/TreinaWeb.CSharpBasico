using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public abstract class Veiculo : IVeiculo
    {
        List<Dono> antigosDonos = new List<Dono>();
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Potencia { get; set; }
        public double QuantidadeCombustivel { get; set; }
        
        public abstract string Ligar();
        public abstract string Desligar();
        public abstract string Abastecer();
        public abstract string Desabastecer();
        
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

        public void AdicionaAntigosDonos(Dono dono)
        {
            antigosDonos.Add(dono);            
        }       

        public List<Dono> ListaAntigosDonos()
        {
            return this.antigosDonos;
        }        
    }
}
