using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Controllers
{
    //https://localhost:44348/gestao-clientes/pagina-inicial

    [Route("")]
    [Route("gestao-clientes")] // Prefixo
    public class HomeController : Controller
    {
        //https://localhost:44348/gestao-clientes/pagina-inicial/10?categoria=15
        //https://localhost:44348/gestao-clientes/pagina-inicial/10/7F1C1C19-1C8F-497D-86A7-B81CFECD1E5B
        [Route("")]
        [Route("pagina-inicial")]
        //[Route("pagina-inicial/{id}")]
        //[Route("pagina-inicial/{id:int}/{categoria?}")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id , Guid categoria)
        {
            return View();
        }
        // Se o Nome da View For o Mesmo Nome do METODO
        // Nao precisa passar a View como parametro
        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return Content("Qualquer Coisa");
            //var filebytes = System.IO.File.ReadAllBytes(@"C:\ISLogFile.txt");
            //var filleName = "ISLogFile.txt";
            //return File(filebytes, System.Net.Mime.MediaTypeNames.Application.Octet, filleName);
           // return Json("{'nome':'Farley Rufino'}");
           // return View();
            //return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("Error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
