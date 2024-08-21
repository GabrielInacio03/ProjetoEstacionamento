using System;
using System.Collections.Generic;
using System.Linq;

namespace Estacionamento
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
    }

    public class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private decimal precoPorHora;

        public Estacionamento(decimal precoPorHora)
        {
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(new Veiculo { Placa = placa, HoraEntrada = DateTime.Now });
            Console.WriteLine($"Veículo com placa {placa} adicionado.");
        }

        public void RemoverVeiculo(string placa)
        {
            var veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);

            if (veiculo == null)
            {
                Console.WriteLine("Veículo não encontrado.");
                return;
            }

            TimeSpan tempoEstacionado = DateTime.Now - veiculo.HoraEntrada;
            decimal valorTotal = (decimal)tempoEstacionado.TotalHours * precoPorHora;
            veiculos.Remove(veiculo);

            Console.WriteLine($"Veículo com placa {placa} removido.");
            Console.WriteLine($"Tempo estacionado: {tempoEstacionado.TotalHours:F2} horas.");
            Console.WriteLine($"Valor a pagar: R${valorTotal:F2}");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo.Placa}, Hora de Entrada: {veiculo.HoraEntrada}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
