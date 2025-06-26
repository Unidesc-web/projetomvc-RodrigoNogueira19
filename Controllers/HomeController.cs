using Microsoft.AspNetCore.Mvc;
using ListaPedidos.Models;
using System.Collections.Generic;

namespace ListaPedidos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Passa lista vazia pra evitar null reference
            var pedidos = new List<Pedido>();
            return View(pedidos);
        }
    }
}
