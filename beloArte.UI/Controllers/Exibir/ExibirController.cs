using beloArte.BLL.ProdutoBLL;
using beloArte.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace beloArte.UI.Controllers.Exibir
{
    public class ExibirController : Controller
    {
        private ProdutoBLL produtoBLL;

        public ActionResult Produto(int codproduto)
        {
            produtoBLL = new ProdutoBLL();
            List<BA_PRODUTO> listaProduto = new List<BA_PRODUTO>();

            listaProduto.Add(produtoBLL.CarregarProduto(codproduto));

            ViewBag.Produto = listaProduto;
  
            return View();
        }

    }
}