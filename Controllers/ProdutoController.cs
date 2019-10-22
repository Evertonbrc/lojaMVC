using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace loja.Controllers
{
    public class ProdutoController : Controller
    {
        /*
        * Precisa retornar um ActionResult
        * ou
        * IActionResult
         */
        public ActionResult Visualizar()
        {
            return View();



            //return new ContentResult() { Content = "<h3>Produto -> Visualizar</h3>", ContentType = "text/html" };
        }
    }
}