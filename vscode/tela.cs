using System;

class Tela
{
    public int MostrarMenu()
    {
        Console.WriteLine("\n\nO que deseja fazer?\n");
        Console.WriteLine("1. Novo");
        Console.WriteLine("2. Listar Produtos");
        Console.WriteLine("3. Remover Produtos");
        Console.WriteLine("4. Entrada Estoque");
        Console.WriteLine("5. Saída Estoque");
        Console.WriteLine("0. Sair\n");

        int opcao = PedirNumeroInt("--");
        return opcao;
    }
    public int PedirNumeroInt(string msg)
    {
        Console.WriteLine(msg);
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    public void Escrever(string msg)
    {
        Console.WriteLine(msg);
    }
}