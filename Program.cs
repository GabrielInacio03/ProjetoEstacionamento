namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento(precoPorHora: 5.00m);

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite a placa do veículo:");
                        string placa = Console.ReadLine();
                        estacionamento.AdicionarVeiculo(placa);
                        break;
                    case "2":
                        Console.WriteLine("Digite a placa do veículo a ser removido:");
                        placa = Console.ReadLine();
                        estacionamento.RemoverVeiculo(placa);
                        break;
                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
