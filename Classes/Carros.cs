using System;
namespace TrabalhoPratico1.Classes
{
    public class Lista
    {
        private Lista inicio;
        private Lista proximo;
        private Lista anterior;
        private int tamanho = 0;
        private Carro carro;

        public Lista()
        {
            carro = new Carro();
        }

        public Lista InicioFim { get => inicio; set => inicio = value; }
        public Lista Proximo { get => proximo; set => proximo = value; }
        public Lista Anterior { get => anterior; set => anterior = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public Carro Carro { get => carro; set => carro = value; }

        public Lista adicionar(Carro novoCarro)
        {
            Lista old = null;

            if (InicioFim != null)
            {
                old = this;
            }

            if (InicioFim == null && Anterior == null)
            {
                InicioFim = this;
            }

            Lista lista = new Lista();
            lista.carro = novoCarro;

            if (old != null) 
            {
                old.Proximo = this;    
            }

            lista.Anterior = old;
            lista.Tamanho++;
            InicioFim.Anterior = this;
            lista.InicioFim = InicioFim;
            return lista;
        }
    }

    public class Carros
    {
        private Lista carros;

        public Carros()
        {
            carros = new Lista();
        }

        public Lista adicionar(Carro novoCarro)
        {
            carros = carros.adicionar(novoCarro);
            return carros;
        }

        public Lista getCarros()
        {
            return carros.InicioFim;
        }

        public Lista pesquisarSePlacaExiste(string placa, Lista pCarros = null)
        {
            if (pCarros == null)
            {
                pCarros = carros.InicioFim;
            }

            if (pCarros == null)
            {
                return null;
            }

            if (pCarros.Carro.Placa == placa)
            {
                return pCarros;
            }

            if (pCarros.Proximo == null)
            {
                return pCarros.Proximo;
            }

            return pesquisarSePlacaExiste(placa, pCarros.Proximo);
        }
    }
}
