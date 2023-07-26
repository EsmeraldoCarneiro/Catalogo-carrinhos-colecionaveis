using System;
using System.Collections.Generic;

class MiniaturaCarro
{

    public string Modelo { get; set; }
    public string Fabricante { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
}

class Program
{

    static List<MiniaturaCarro> catalogo = new List<MiniaturaCarro>();

    static void Main(){

        while (true){

            Console.WriteLine("===== Catálogo de Carrinhos Miniaturas =====");
            Console.WriteLine("1 - Adicionar Carrinho");
            Console.WriteLine("2 - Lstar Carrinho");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarCarrinho();
                    break;
                case "2":
                    ListarCarrinhos();
                    break;
                case "3":
                    Console.WriteLine("Saindo do programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();           
        }
    }

    static void AdicionarCarrinho()
    {

        Console.WriteLine("===== Adicionar Carrinho =====");
        MiniaturaCarro carrinho = new MiniaturaCarro();

        Console.Write("Modelo: ");
        carrinho.Modelo = Console.ReadLine();

        Console.Write("fabricante: ");
        carrinho.Fabricante = Console.ReadLine();

        Console.Write("Ano: ");
        if (int.TryParse(Console.ReadLine(), out int ano)){

            carrinho.Ano = ano;
        }
        else
        {
            Console.WriteLine("Ano inválido. O ano será definido como 0.");
            carrinho.Ano = 0;
        }

        Console.Write("Cor: ");
        carrinho.Cor = Console.ReadLine();

        catalogo.Add(carrinho);
        Console.WriteLine("Carrinho adicionado com sucesso!");
    }

    static void ListarCarrinhos()
    {
        Console.WriteLine("===== Lista de Carrinhos =====");
                if (catalogo.Count == 0)
        {
            Console.WriteLine("O catálogo está vazio.");
            return;
        }

        foreach (var carrinho in catalogo)
        {
            Console.WriteLine($"Modelo: {carrinho.Modelo}");
            Console.WriteLine($"Fabricante: {carrinho.Fabricante}");
            Console.WriteLine($"Ano: {carrinho.Ano}");
            Console.WriteLine($"Cor: {carrinho.Cor}");
            Console.WriteLine();
        }
    }
}
