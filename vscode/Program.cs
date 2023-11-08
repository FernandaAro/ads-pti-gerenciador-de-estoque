using System;

namespace LojaDeJogos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tela tela = new Tela();
            GerenciadorEstoque gerenciador = new GerenciadorEstoque();

            tela.Escrever("\n---SOFTWARE GERENCIADOR DE ESTOQUE---");

            bool executando = true;
            while (executando == true)
            {
                int opcao = tela.MostrarMenu();
                if (opcao == 0)
                {
                    executando = false;
                    tela.Escrever("\nSaindo do programa...");
                    tela.Escrever("---");
                }

                else
                {
                    if (opcao == 1)
                    {
                        Jogo jogo = new Jogo();
                        tela.Escrever("\nInforme o nome do jogo: ");
                        jogo.Nome = Console.ReadLine();

                        tela.Escrever("\nInforme o preço: ");
                        jogo.Preco = Convert.ToDouble(Console.ReadLine());

                        //tela.Escrever("\nInforme a quantidade de jogadores: ");
                        //jogo.Jogadores = Convert.ToInt32(Console.ReadLine());

                        //tela.Escrever("\nInforme a plataforma: ");
                        //jogo.Plataforma = Console.ReadLine();

                        //tela.Escrever("\nInforme o desenvolvedor: ");
                        //jogo.Desenvolvedor = Console.ReadLine();

                        gerenciador.Adicionar(jogo);
                        tela.Escrever("\nJogo adicionado!");
                        tela.Escrever("---");
                    }

                    else if (opcao == 2)
                    {
                        gerenciador.Listar();
                        tela.Escrever("---");
                    }

                    else if (opcao == 3)
                    {
                        gerenciador.Listar();
                        tela.Escrever("\nInforme qual item deseja remover: ");
                        gerenciador.Remover(Convert.ToInt32(Console.ReadLine()) - 1);
                        tela.Escrever("\nItem removido!");
                        tela.Escrever("---");
                    }

                    else if (opcao == 4)
                    {
                        gerenciador.Listar();
                        tela.Escrever("\nInforme em qual item deseja adicionar o estoque: ");
                        int posicao = (Convert.ToInt32(Console.ReadLine()) - 1);
                        tela.Escrever("\nInforme quanto deseja adicionar: ");
                        int qtd = (Convert.ToInt32(Console.ReadLine()));
                        gerenciador.EntradaEstoque(posicao, qtd);
                        tela.Escrever("\nEstoque adicionado!");
                        tela.Escrever("---");
                    }

                    else if (opcao == 5)
                    {
                        gerenciador.Listar();
                        tela.Escrever("\nInforme em qual item deseja remover o estoque: ");
                        int posicao = (Convert.ToInt32(Console.ReadLine()) - 1);
                        tela.Escrever("\nInforme quanto deseja remover: ");
                        int qtd = (Convert.ToInt32(Console.ReadLine()));
                        gerenciador.SaidaEstoque(posicao, qtd);
                        tela.Escrever("\nSaída realizada!");
                        tela.Escrever("---");
                    }
                }
            }
        }
    }
}