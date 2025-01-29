using System.ComponentModel;
using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("Monitor");
listaString.Add("Teclado");
listaString.Add("Mouse");
listaString.Add("Fone");

Console.WriteLine($"Lista de periféricos: {listaString.Count} - {listaString.Capacity}");

listaString.Add("MousePad");

Console.WriteLine($"Lista de periféricos: {listaString.Count} - {listaString.Capacity}");

listaString.Remove("Monitor");

Console.WriteLine($"Lista de periféricos: {listaString.Count} - {listaString.Capacity}");



/*Console.WriteLine("Percorrendo uma lista com FOR");
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Periférico N° {contador} - {listaString[contador]}");
}
*/

/*Console.WriteLine("Percorrendo uma lista com FOREACH");
int contadorForEach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Periférico N° {contadorForEach} - {item}");
    contadorForEach++;
}
*/

/*int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

int[] arraysInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arraysInteirosDobrados, arrayInteiros.Length);
*/

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

/*for (int contador = 0; contador < arrayInteiros.Length; contador++) 
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}
*/

/*foreach(int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}
*/

/*string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida ");
            break;
    }
}

Console.WriteLine("O programa se encerrou.");
/*


/*int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número! (0 para parar.)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;

} while (numero != 0);

Console.WriteLine($"A soma dos números digitados é: {soma}");
*/

/*int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número! (0 para encerrar.)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;

} while (numero != 0);

Console.WriteLine($"A soma dos números é: {soma}");
*/

/*int numero = 5;


int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 7)
    {
        break;
    }
    
}
*/

/*for (int contador = 0; contador <= 10; contador++) 
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
*/

/*Calculadora calc = new Calculadora();

calc.RaizQuadrada(9);
*/

/*int numero = 10;
Console.WriteLine("numero");

Console.WriteLine("Incrementando o dez");
numero++;

Console.WriteLine("Decrementando o dez");
numero--;

Console.WriteLine(numero);
*/

/*calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
*/

/*calc.Somar(10, 10);
calc.Subtrair(10, 10);
calc.Multiplicar(10, 10);
calc.Dividir(10, 10);
calc.Potencia(10, 10);
*/

/*Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "i":
    case "e":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é uma vogal!");
        break;
}
*/

/*Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

if (letra == "a")
{
    Console.WriteLine("É uma vogal");
}

else if (letra == "e")
{
    Console.WriteLine("É uma vogal");
}

else if (letra == "i")
{
    Console.WriteLine("É uma vogal");
}

else if (letra == "o")
{
    Console.WriteLine("É uma vogal");
}

else if (letra == "u")
{
    Console.WriteLine("É uma vogal");
}
else
{
    Console.WriteLine("Não é uma vogal!");
}
*/

/*int quantidadeEmEstoque = 10;
int quantidadeCompra = 11;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos essa quantidade em estoque :(");
}

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}" );
*/

/*int n1 = 10;
Convert.ToDouble(n1);

double n2 = 10;
Convert.ToInt32(n2);

string n3 = "10";
Convert.ToInt32(n3);

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
*/

/*int n1 = 10;
double n1Convertido = Convert.ToDouble(n1);

double n2 = 10;
int n2Convertido = Convert.ToInt32(n2);

string n3 = "10";
int n3Convertido = Convert.ToInt32(n3);

Console.WriteLine(n1Convertido);
Console.WriteLine(n2Convertido);
Console.WriteLine(n3Convertido);
*/

/*int a = 20;
int b = 10;
int c = a + b;

c += 20;

Console.WriteLine(c);
*/

/*int a = 20;
int b = 10;

int c = a + b;
Console.WriteLine(c);
*/

/*DateTime dataAtual = DateTime.Now;
DateTime dataFutura = DateTime.Now.AddDays(10);
DateTime apenasData = DateTime.Now;
DateTime apenasMinutosEHoras = DateTime.Now;

Console.WriteLine(dataAtual);
Console.WriteLine(dataFutura);
Console.WriteLine(apenasData.ToString("dd/MM/yyyy"));
Console.WriteLine(apenasMinutosEHoras.ToString("HH:mm"));
*


/*string apresentacao = "Olá, seja bem vindo";

string nome = "Rikelmy";

int idade = 17;

double altura = 1.73;

decimal dinheiro = 1.50M;

bool condicao = true;

Console.WriteLine($"{apresentacao} {nome}, você tem {idade} anos e {altura} de altura. Possui {dinheiro} na conta e sua condição de confuso é {condicao}");
*/

/*string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.73;

decimal preco = 1.80M;

bool condicao = true;


Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável quantidade: " + altura);
Console.WriteLine("Valor da variável quantidade: " + preco);
Console.WriteLine("Valor da variável quantidade: " + condicao);
Console.WriteLine(apresentacao);
*/

/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Rikelmy";
pessoa1.Idade = 17;
pessoa1.Apresentar();
*/