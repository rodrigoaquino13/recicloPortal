using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecicloPortal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RecicloPortal.Controllers
{
    public class TabelaController : Controller
    {
        private readonly ILogger<TabelaController> _logger;

        public TabelaController(ILogger<TabelaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
