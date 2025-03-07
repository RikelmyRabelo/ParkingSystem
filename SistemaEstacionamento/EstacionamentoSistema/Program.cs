﻿using System.Linq.Expressions;
using SistemaEstacionamento.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
int capacidade = 0;

try
{
    // Tenta obter os valores iniciais do estacionamento
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                      "Digite o preço inicial:");
    precoInicial = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Agora digite o preço por hora:");
    precoPorHora = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Por fim, a capacidade do estacionamento: ");
    capacidade = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: Entrada inválida. Por favor, insira um número válido. " + ex.Message);
    return;
}
catch (OverflowException ex)
{
    Console.WriteLine("Erro: Número muito grande. Por favor, insira um valor menor. " + ex.Message);
    return;
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao obter os valores iniciais do estacionamento: " + ex.Message);
    return;
}

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora, capacidade);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");