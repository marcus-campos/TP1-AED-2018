using System;

namespace TrabalhoPratico1
{
    class MainClass
    {
        static Classes.Garagem garagem;
        static Classes.Carros carros;

        public static void Main(string[] args)
        {
            int op;
            garagem = new Classes.Garagem();
            carros = new Classes.Carros();

            do
            {
                op = menu();

                switch (op)
                {
                    case 1: // Colocar carro na garagem
                        string placa = dynamicMenu("Placa: ", true);

                        if (carros.pesquisarSePlacaExiste(placa) == null)
                        {
                            string SN = dynamicMenu("Carro não cadastrado. \nDeseja cadastra-lo? (S,n): ", false).ToUpper();

                            if (SN == "S" || SN == "")
                            {
                                adicionarCarro(placa); 
                            }
                        }

                        break;

                    case 2: // Exibir carros na garagem
                        Console.Clear();
                        listarCarrosNaGaragem(garagem.getGaragem());
                        dynamicMenu("", false, true);
                        break;

                    case 3: // Levar carro para o lavajato
                        
                        break;

                    case 4: // Exibir carros no lavajato

                        break;

                    case 5: // Atender carro no lavajato
                      
                        break;

                    case 6: // Exibir cadastro de carros
                        
                        break;

                }

            } while (op != 7);
        }

        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Colocar carro na garagem");
            Console.WriteLine("2 - Exibir carros na garagem");
            Console.WriteLine("3 - Levar carro para o lavajato");
            Console.WriteLine("4 - Exibir carros no lavajato");
            Console.WriteLine("5 - Atender carro no lavajato");
            Console.WriteLine("6 - Exibir cadastro de carros");
            Console.WriteLine("7 - Sair");
            Console.Write("Opção: ");

            return (int.Parse(Console.ReadLine()));
        }


        static string dynamicMenu(string msg, bool clear = false, bool readKey = false)
        {
            string value = "";

            if (clear)
            {
                Console.Clear();
            }

            Console.Write(msg);

            if (readKey)
            {
                Console.ReadKey();
                return "";
            }

            value = Console.ReadLine();

            return value;
        }

        static void adicionarCarro(string placa)
        {
            Classes.Carro carro = new Classes.Carro();
            carro.Placa = placa;
            carro.Modelo = dynamicMenu("Modelo: ", true);
            carro.Cor = dynamicMenu("Cor: ");
            carro.NomeProprietario = dynamicMenu("Nome do proprietário: ");
            carro.AnoFabricacao = int.Parse(dynamicMenu("Ano de fabricação: "));
            carro.NumeroLavagens = 0;

            carros.adicionar(carro);
            garagem.adicionar(carro);

            dynamicMenu("Carro adicionado com sucesso!!!", true, true);
        }

        static Classes.Pilha listarCarrosNaGaragem(Classes.Pilha _garagem = null)
        {
            if (_garagem == null)
            {
                return null;
            }

            Console.WriteLine("Placa: {0}, Modelo: {1}, Cor: {2}, Proprietário {3}, Fabricação: {4}, Lavagens: {5}.", 
                              _garagem.Carro.Placa, _garagem.Carro.Modelo, _garagem.Carro.Cor, _garagem.Carro.NomeProprietario, _garagem.Carro.AnoFabricacao, _garagem.Carro.NumeroLavagens);
            return listarCarrosNaGaragem(_garagem.Anterior);
        }
    }
}
