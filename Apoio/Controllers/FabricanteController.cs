using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locacoes.Controllers
{
    public class FabricanteController : Controller
    {

        public static List<Fabricante> Fabricantes = new List<Fabricante>()
        {
            new Fabricante()
            {
                Id = 1,
                Nome = "Xupinto",
                Pais = "Cazaquistão"
            },
            new Fabricante()
            {
                Id = 2,
                Nome = "Mairão 9 gramas",
                Pais = "Congo"
            }
        };
        public IActionResult Index()
        {
            return View(Fabricantes);
        }
    }
}
