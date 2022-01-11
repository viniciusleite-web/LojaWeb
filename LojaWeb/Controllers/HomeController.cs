using LojaWeb.Controllers.Base;
using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers
{
    public class HomeController : BaseController
    {
     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacidade do Carlos";
            ViewBag.Nome = "Carlos";
            Mensagem("info: Tela de privacidade", "info");
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(string Id,string Nome)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagem("Erro: Inssira um Nome","error");
                return View();
            }
            return View("Index");
        }
        
    }
}
