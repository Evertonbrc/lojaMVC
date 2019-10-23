using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lojaVirtual.Libraries.Email;
using lojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace lojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult ContatoAcao()
        {
            Contato contato = new Contato();
            contato.Nome = HttpContext.Request.Form["nome"];
            contato.Email = HttpContext.Request.Form["email"];
            contato.Texto = HttpContext.Request.Form["texto"];

            //ContatoEmail.EnviarContatoPorEmail(contato);

            ViewData["MSG_S"] = "Mensagem de contato enviada com sucesso!";

            return View("Contato");

        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}