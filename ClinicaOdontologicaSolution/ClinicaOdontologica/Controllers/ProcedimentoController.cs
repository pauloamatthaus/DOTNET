using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaOdontologica.Data;
using ClinicaOdontologica.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaOdontologica.Controllers
{
    public class ProcedimentoController : Controller
    {
        public IActionResult CadastroProcedimento()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroProcedimento(Procedimento procedimento)
        {
            int id = DataBase.Instance().GetAllPacientes().Count + 1;
            procedimento.id = id;

            DataBase.Instance().AddProcedimento(procedimento);

            ViewData["exibirAlert"] = true;

            ModelState.Clear();

            return View("CadastroProcedimento");
        }
    }
}