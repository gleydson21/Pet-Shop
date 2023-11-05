using Microsoft.AspNetCore.Mvc;
using Pet_Shop.Models;
using Pet_Shop.Models.Agendamento;

namespace Pet_Shop.Controllers

    public class AgendamentoController : Controller
{
    private readonly IRepository<Agendamento> repository;

    public AgendamentoController(IRepository<Agendamento> repository)
    {
        this.repository = repository;
    }

    [HttpPost]
    public IActionResult Agendar(Agendamento agendamento)
    {
        // Valide os dados de entrada
        if (agendamento.NomeCliente == null || agendamento.NomeCliente == null || agendamento.Servico == null || agendamento.DataHora == null)
        {
            return BadRequest();
        }

        // Adiciona o agendamento ao banco de dados
        repository.Add(agendamento);

        // Salva as alterações no banco de dados
        repository.SaveChanges();

        // Retorne uma mensagem de sucesso
        return Ok();
    }
}
}
