using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers
{
    public class Mensagem : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
