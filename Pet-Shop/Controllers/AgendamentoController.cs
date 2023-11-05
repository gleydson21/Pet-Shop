using Pet_Shop.Models.Agendamento;
using Pet_Shop.Models.Interfaces;

public class AgendamentoRepository : IRepository<Agendamento>
{
    private readonly IRepository<Agendamento> repository;

    //public AgendamentoRepository(IRepository<Agendamento> repository)
    //{
    //    this.repository = repository;
    //}

    public void Add(Agendamento agendamento)
    {
        // Valide os dados de entrada
        if (agendamento == null)
        {
            throw new ArgumentNullException("agendamento");
        }

        if (agendamento.NomeCliente == null)
        {
            throw new ArgumentException("O nome do cliente é obrigatório.");
        }

        if (agendamento.NomePet == null)
        {
            throw new ArgumentException("O nome do pet é obrigatório.");
        }

        // A espécie do pet não pode ser nulo, mas pode ser vazio
        if (agendamento.Especie == null)
        {
            agendamento.Especie = string.Empty;
        }

        // A raça do pet não pode ser nulo, mas pode ser vazio
        if (agendamento.Raça == null)
        {
            agendamento.Raça = string.Empty;
        }

        if (agendamento.Servico == null)
        {
            throw new ArgumentException("O serviço é obrigatório.");
        }

        if (agendamento.DataHora != null)
        {
            // Valide a data e hora
            if (agendamento.DataHora < DateTime.Now)
            {
                throw new ArgumentException("A data e hora devem ser futuras.");
            }

            // Adiciona o agendamento ao banco de dados
            //repository.Add(agendamento);
        }
        else
        {
            throw new ArgumentException("A data e hora são obrigatórias.");
        }
    }

    public void SaveChanges()
    {
        throw new NotImplementedException();
    }

    // ...
}
