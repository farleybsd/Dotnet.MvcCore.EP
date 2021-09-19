using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev.Io.Ui.Site.Data;
using Microsoft.AspNetCore.Mvc;


namespace Dev.Io.Ui.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        //public IActionResult Index([FromServices] IPedidoRepository pedido) Injencao de depedencia no metodo
        public IActionResult Index()
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
