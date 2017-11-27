using beloArte.BLL.ProdutoBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace beloArte.UI.Controllers
{
    public class PaginaController : Controller
    {
        private ProdutoBLL produtoBLL;

        public ActionResult Principal()
        {
        //    produtoBLL = new ProdutoBLL();
        //    produtoBLL.CarregarTodosProdutos();

            return View("Index");
        }
    }
}