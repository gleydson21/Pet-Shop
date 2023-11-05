namespace Pet_Shop.Models.Interfaces
{
    public interface IAgendamento
    {
        DateTime DataHora { get; set; }
        int Id { get; set; }
        string NomeCliente { get; set; }
        string NomePet { get; set; }
        string Servico { get; set; }
    }
}