using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Este es un mensaje de log de prueba");
            _logger.LogDebug("Este es un mensaje de debug de prueba");
            _logger.LogCritical("Este es un mensaje critical de prueba");
            _logger.LogError("Este es un mensaje de error de prueba");
            _logger.LogTrace("Este es un mensaje de trace de prueba");
            _logger.LogWarning("Este es un mensaje de warning de prueba");

            var proyectos = repositorioProyectos.obtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndex() { Proyectos = proyectos }; 
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.obtenerProyectos();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}