using Locacoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locacoes.Controllers
{
    public class ClienteController : Controller
    {
        public static List<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente()
            {
                Id = 1,
                Nome = "Arthur",
                Email = "tutuzinho@gmail.com",
                Telefone = "(24) 999873579",
                Cidade = "Volta Redonda"
            },
            new Cliente()
            {
                Id = 2,
                Nome = "Larissossauro",
                Email = "odeiaKPOP@gmail.com",
                Telefone = "(24)40028922",
                Cidade = "Barra Mansa"
            }
        };
        public IActionResult Index()
        {
            return View(Clientes);
        }
    }
}
