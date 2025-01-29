using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDeProdutos
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool DisponivelParaVenda { get; set; }
    }

    public class Program
    {
        static List<Produto> produtos = new List<Produto>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Descrição do produto: ");
            produto.Descricao = Console.ReadLine();

            Console.Write("Valor do produto: ");
            produto.Valor = decimal.Parse(Console.ReadLine());

            Console.Write("Disponível para venda (sim/não): ");
            produto.DisponivelParaVenda = Console.ReadLine().ToLower() == "sim";

            produtos.Add(produto);

            Console.WriteLine("Produto cadastrado com sucesso!");
            ListarProdutos();
        }

        static void ListarProdutos()
        {
            var produtosOrdenados = produtos.OrderBy(p => p.Valor).ToList();

            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtosOrdenados)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Valor: {produto.Valor:C}");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}

