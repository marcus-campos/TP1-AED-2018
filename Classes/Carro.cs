using System;
namespace TrabalhoPratico1.Classes
{
    public class Carro
    {
        private string placa;
        private string modelo;
        private string cor;
        private string nomeProprietario;
        private int anoFabricacao;
        private int numeroLavagens;

        //Encapsulamento
        public string Placa { get => placa; set => placa = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string NomeProprietario { get => nomeProprietario; set => nomeProprietario = value; }
        public int AnoFabricacao { get => anoFabricacao; set => anoFabricacao = value; }
        public int NumeroLavagens { get => numeroLavagens; set => numeroLavagens = value; }
    }
}
