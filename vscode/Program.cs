using System;

namespace LojaDeJogos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Jogo j1 = new Jogo();
            j1.Nome = "Super Mario Odyssey";
            j1.Preco = 299.00;
            j1.Jogadores = 2;
            j1.Plataforma = "Nintendo Switch";
            j1.Desenvolvedor = "Nintendo";
            j1.Estoque = 0;

            Jogo j2 = new Jogo();
            j2.Nome = "Stardew Valley";
            j2.Preco = 24.99;
            j2.Jogadores = 4;
            j2.Plataforma = "Nintendo Switch, Windows, Xbox, Playstation, Mac";
            j2.Desenvolvedor = "ConcernedApe";
            j2.Estoque = 0;

            Jogo j3 = new Jogo();
            j3.Nome = "Ori and the Blind Forest";
            j3.Preco = 99.00;
            j3.Jogadores = 1;
            j3.Plataforma = "Nintendo Switch, Windows, Xbox";
            j3.Desenvolvedor = "Moon Studios";
            j3.Estoque = 0;

            Jogo j4 = new Jogo();
            j4.Nome = "Horizon Zero Dawn";
            j4.Preco = 199.90;
            j4.Jogadores = 1;
            j4.Plataforma = "Windows, Playstation";
            j4.Desenvolvedor = "Guerrilla Games";
            j4.Estoque = 0;

            GerenciadorEstoque gerenciador = new GerenciadorEstoque();
            gerenciador.Adicionar(j1);
            gerenciador.Adicionar(j2);
            gerenciador.Adicionar(j3);
            gerenciador.Adicionar(j4);
            gerenciador.Listar();

            Console.WriteLine("\nRemovendo posição 1");
            gerenciador.Remover(1);
            gerenciador.Listar();

            Console.WriteLine("\nAdicionando 4 itens no Horizon Zero Dawn");
            gerenciador.EntradaEstoque(2, 4);
            gerenciador.Listar();
        }
    }
}