using barbearia_tranquila.Models;
using Microsoft.AspNetCore.Mvc;
using static barbearia_tranquila.Models.AgendarModel;

public class AgendamentoController : Controller
{

    private static List<AgendarModel> _lista = new List<AgendarModel>();
    private static int _id = 0;

    [HttpPost]
    public IActionResult Delete(int id)
    {
        _lista.RemoveAt(_lista.FindIndex(a => a.Id == id));

        return RedirectToAction("Agendamentos");
    }

    [HttpGet]
    public IActionResult Agendamentos()
    {
        if (_lista.Count == 0)
        {
            TempData["agendaVazia"] = "Você ainda não tem nenhum agendamento!";
        }

        return View(_lista);
    }

    [HttpGet]
    public IActionResult Agendar()
    {
        AgendarModel model = new AgendarModel
        {
            Data = DateTime.Now,
            Status = StatusEnum.Pendente
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Agendar(AgendarModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        _lista.Add(model);
        model.Id = ++_id;

        TempData["msg"] = "Agendamento realizado com sucesso!";

        return View(model);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var agendamento = _lista.FirstOrDefault(a => a.Id == id);
        if (agendamento == null)
        {
            TempData["msg"] = "Agendamento não encontrado!";
            return RedirectToAction("Agendamentos");
        }

        return View(agendamento);
    }

    [HttpPost]
    public IActionResult Edit(AgendarModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var agendamento = _lista.FirstOrDefault(a => a.Id == model.Id);
        if (agendamento == null)
        {
            TempData["msg"] = "Agendamento não encontrado!";
            return RedirectToAction("Agendamentos");
        }

        // Atualiza os dados do agendamento
        agendamento.Nome = model.Nome;
        agendamento.Telefone = model.Telefone;
        agendamento.Data = model.Data;
        agendamento.Hora = model.Hora;
        agendamento.Servico = model.Servico;
        agendamento.Profissional = model.Profissional;
        agendamento.Observacoes = model.Observacoes;
        agendamento.Status = model.Status;

        TempData["msg"] = "Agendamento atualizado com sucesso!";
        return RedirectToAction("Agendamentos");
    }
}
