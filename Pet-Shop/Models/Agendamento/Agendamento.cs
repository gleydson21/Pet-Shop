namespace Pet_Shop.Models.Agendamento
{
    public class Agendamento
    {
        public int Id { get; set; }
        public required string NomeCliente { get; set; }
        public required string NomePet { get; set; }
        public required string Servico { get; set; }
        public DateTime DataHora { get; set; }
    }
}