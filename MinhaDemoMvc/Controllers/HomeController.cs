using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(string id , string categoria)
        {
            return View();
        }
        // Se o Nome da View For o Mesmo Nome do METODO
        // Nao precisa passar a View como parametro
        public IActionResult Privacy()
        {
            return View();
            //return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
