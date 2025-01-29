using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Conversor de Moedas");
        Console.WriteLine("1 - Real para Dólar");
        Console.WriteLine("2 - Dólar para Real");
        Console.WriteLine("3 - Real para Euro");
        Console.WriteLine("4 - Euro para Real");
        Console.WriteLine("Por favor, escolha uma das opções acima");

        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um valor para ser convertido: ");
        double valor = double.Parse(Console.ReadLine());

        double resultado = 0;
        string mensagem = "";
        switch (opcao)
        {
            case 1: resultado = RealParaDolar(valor);
                mensagem = $"{valor} reais equivalem a {resultado.ToString("F2")} dólares.";
                break;
            case 2: resultado = DolarParaReal(valor);
                mensagem = $"{valor} dólares equivalem a {resultado.ToString("F2")} reais.";
                break;
            case 3: resultado = RealParaEuro(valor);
                mensagem = $"{valor} reais equivalem a {resultado.ToString("F2")} euros.";
                break;
            case 4: resultado = EuroParaReal(valor);
                mensagem = $"{valor} euros equivalem a {resultado.ToString("F2")} reais.";
                break;
                default: 
                    Console.WriteLine("Opção inválida, por favor veja o menu e tente novamente!");
                return;
        }

        static double RealParaDolar (double valor)
        {
            return valor / 6.38;
        }
        static double DolarParaReal (double valor)
        {
            return valor * 6.38;
        }
        static double RealParaEuro (double valor)
        {
            return valor / 6.22;
        }
        static double EuroParaReal (double valor)
        {
            return valor * 6.22;
        }

        Console.WriteLine(mensagem);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();

    }
}