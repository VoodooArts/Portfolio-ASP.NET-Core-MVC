using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoryProjects repositoryProjects;

        public HomeController(ILogger<HomeController> logger, IRepositoryProjects repositoryProjects)
        {
            _logger = logger;
            this.repositoryProjects = repositoryProjects;
        }

        public IActionResult Index()
        {
            var proyectos = repositoryProjects.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() {Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult ProjectSection()
        {
            var proyectos = repositoryProjects.ObtenerProyectos();
            return View(proyectos);
        }
        
        public IActionResult Contact() {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            return RedirectToAction("Thanks");

        }

        public IActionResult Thanks()
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
