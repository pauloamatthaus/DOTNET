using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaOdontologica.Data;
using ClinicaOdontologica.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaOdontologica.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult CadastroPaciente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroPaciente(Paciente paciente)
        {
            int id = DataBase.Instance().GetAllPacientes().Count + 1;
            paciente.id = id;

            DataBase.Instance().AddPaciente(paciente);

            ViewData["exibirAlert"] = true;

            ModelState.Clear();

            return View("CadastroPaciente");
        }

        public IActionResult DeletarPaciente(int id)
        {
            DataBase.Instance().RemovePaciente(id);

            return RedirectToAction("Index", "Home");
        }
    }
}