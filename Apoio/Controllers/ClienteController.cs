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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            cliente.Id = Clientes.Select(x => x.Id).Max() + 1; Clientes.Add(cliente);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(Clientes.Where(cli => cli.Id == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Cliente cliente)
        {
            var clienteOld = Clientes.Where(cli => cli.Id == cliente.Id).First();
            Clientes.Remove(clienteOld);
            Clientes.Add(cliente);
            return RedirectToAction("index");
        }
        public IActionResult Details(int id)
        {
            return View(Clientes.Where(cli => cli.Id == id).First());
        }
        
        public IActionResult Delete(int id)
        {
            return View(Clientes.Where(cli => cli.Id == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = Clientes.Where(cliente => cliente.Id == id).First();
            Clientes.Remove(cliente);
            return RedirectToAction("index");
        }




    }
}