namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private int capacidade = 0;

        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora, int capacidade)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.capacidade = capacidade;
        }

        public void AdicionarVeiculo()
        {
            if (veiculos.Count >= capacidade)
            {
                Console.WriteLine("Erro: O estacionamento está cheio! Nenhum veículo pode ser adicionado no momento.");
                return;
            }

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(new Veiculo(placa.ToUpper()));
        }

        public void RemoverVeiculo()
        {
            // Verifica se há veículos cadastrados
            if (veiculos.Any())
            {
                Console.WriteLine("Carros cadastrados:");
                foreach (var Veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {Veiculo.Placa} - Hora de Entrada: {Veiculo.HoraEntrada.ToString("HH:mm:ss")}");
                }

                // Solicita a placa do veículo a ser removido
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = int.Parse(Console.ReadLine());
                    if (horas <= 1)
                    {
                        Console.WriteLine("Você ficou apenas uma hora ou menos, por isso recebeu R$5 de desconto no valor total.");
                        decimal valorTotal = precoInicial + precoPorHora * horas - 5;
                        Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    else
                    {
                        decimal valorTotal = precoInicial + precoPorHora * horas;
                        Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
                    }

                    // Remove o veículo da lista
                    veiculos.Remove(veiculos.First(x => x.Placa.ToUpper() == placa.ToUpper()));
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados para remover.");
            }
        }

        public void ListarVeiculos()
        {
            ExibirCapacidade();
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa} - Hora de Entrada: {veiculo.HoraEntrada.ToString("HH:mm:ss")}");

                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


        public void ExibirCapacidade()
        {
            Console.WriteLine($"Capacidade total: {capacidade}");
            Console.WriteLine($"Vagas disponíveis: {capacidade - veiculos.Count}");

            if (veiculos.Count >= capacidade)
            {
                Console.WriteLine("O estacionamento está cheio!⚠️");
            }

        }

        public class Veiculo
        {
            public string Placa { get; set; }
            public DateTime HoraEntrada { get; set; }

            public Veiculo(string placa)
            {
                Placa = placa;
                HoraEntrada = DateTime.Now;
            }
        }
    }
}