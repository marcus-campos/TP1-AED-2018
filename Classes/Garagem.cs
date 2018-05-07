using System;
namespace TrabalhoPratico1.Classes
{
    public class Pilha
    {
        private Pilha anterior;
        private Carro carro;

        public Pilha()
        {
            carro = new Carro();
        }

        public Pilha Anterior { get => anterior; set => anterior = value; }
        public Carro Carro { get => carro; set => carro = value; }

        public Pilha adicionar(Carro novoCarro)
        {
            Pilha old = null;

            if (Anterior != null) 
            {
                old = this;   
            }

            Pilha pilha = new Pilha();
            pilha.carro = novoCarro;
            pilha.Anterior = old;
            return pilha;
        }

        public Pilha remover()
        {
            return this.Anterior;
        }
    }

    public class Garagem
    {
        private Pilha garagem;

        public Garagem()
        {
            garagem = new Pilha();
        }

        public Pilha adicionar(Carro carro)
        {
            garagem = garagem.adicionar(carro);
            return garagem;
        }

        public Pilha remover()
        {
            return garagem.remover();
        }

        public Pilha pesquisarSePlacaExiste(string placa, Pilha pGaragem = null)
        {
            if (pGaragem == null)
            {
                pGaragem = garagem;
            }

            if (pGaragem.Carro.Placa == placa) 
            {
                return pGaragem;
            }

            if (pGaragem.Anterior == null)
            {
                return pGaragem.Anterior;
            }

            return pesquisarSePlacaExiste(placa, pGaragem.Anterior);
        }

        public Pilha getGaragem()
        {
            return garagem;
        }
    }
}
