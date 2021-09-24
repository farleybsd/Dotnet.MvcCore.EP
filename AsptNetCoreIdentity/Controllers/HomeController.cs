using AsptNetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AsptNetCoreIdentity.Controllers
{
    //[Authorize] Para todos os metodos tem que estar autenticado
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles ="Admin,Gestor")] // Autorizazao
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize(Policy = "PodeExcluir")] // Autorizazao
        public IActionResult SecretClamin()
        {
            return View("Secret");
        }

        [Authorize(Policy = "PodeEscrever")] // Autorizazao
        public IActionResult SecretClaminPodeEscrever()
        {
            return View("Secret");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
