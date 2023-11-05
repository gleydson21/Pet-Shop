using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pet_Shop.Views.Home
{
    public class Agendamento
    {
        public required string NomeCliente { get; set; }
        public required string NomePet { get; set; }
        public required string Especie { get; set; }
        public required string Raça { get; set; }
        public required string Servico { get; set; }
        public DateTime DataHora { get; set; }
    }

    public class PetShop
    {
        private readonly List<Agendamento> agendamentos;

        public PetShop()
        {
            this.agendamentos = new List<Agendamento>();
        }

        public bool Agendar(Agendamento agendamento)
        {
            // Verifica se o horário está disponível
            if (!this.agendamentos.Any(a => a.DataHora == agendamento.DataHora))
            {
                // Adiciona o agendamento à lista
                this.agendamentos.Add(agendamento);
                return true;
            }

            return false;
        }

        public void ListarAgendamentos()
        {
            foreach (var agendamento in this.agendamentos)
            {
                Console.WriteLine($"Nome do cliente: {agendamento.NomeCliente}");
                Console.WriteLine($"Nome do pet: {agendamento.NomePet}");
                Console.WriteLine($"Espécie: {agendamento.Especie}");
                Console.WriteLine($"Raça: {agendamento.Raça}");
                Console.WriteLine($"Serviço: {agendamento.Servico}");
                Console.WriteLine($"Data e hora: {agendamento.DataHora}");
            }
        }
    }
}