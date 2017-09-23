using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace beloArte.UI.Controllers.Carrinho
{
    public class CarrinhoController : Controller
    {
        // GET: Carrinho
        public ActionResult ProdutosAdd()
        {
            return View();
        }
    }
}