using Pet_Shop.Models.Interfaces;

namespace Pet_Shop.Models.Agendamento
{
    public class Agendamento : IAgendamento
    {
        public int Id { get; set; }
        public required string NomeCliente { get; set; }
        public required string NomePet { get; set; }
        public required string Servico { get; set; }
        public DateTime DataHora { get; set; }
        public object Especie { get; internal set; }
        public object Raça { get; internal set; }
    }
}