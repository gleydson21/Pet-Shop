using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using System;
using System.Collections.Generic;

namespace PetShop.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Agendamento> agendamentos = ObterAgendamentos();

            return View(agendamentos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Agendamento agendamento)
        {
            // Aqui você pode realizar o tratamento dos dados (salvar em um banco de dados, etc.)

            return RedirectToAction("Index");
        }

        private List<Agendamento> ObterAgendamentos()
        {
            // Exemplo de agendamentos apenas para demonstração
            return new List<Agendamento>
            {
                new Agendamento { Id = 1, NomeCliente = "John Doe", NomePet = "Rex", Servico = "Banho e Tosa", DataHora = DateTime.Now.AddDays(1) },
                new Agendamento { Id = 2, NomeCliente = "Jane Doe", NomePet = "Fluffy", Servico = "Consulta Veterinária", DataHora = DateTime.Now.AddDays(2) },
                new Agendamento { Id = 3, NomeCliente = "Alex Smith", NomePet = "Max", Servico = "Corte de Unhas", DataHora = DateTime.Now.AddDays(3) },
            };
        }
    }
}

