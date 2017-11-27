using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beloArte.Infra.ProdutoINFRA;
using beloArte.DAL.ProdutoDAL;
using beloArte.Domain;

namespace beloArte.BLL.ProdutoBLL
{
    public class ProdutoBLL
    {
        private ProdutoDAL produtoDAL;

        public BA_PRODUTO CarregarProduto(int codproduto)
        {
            produtoDAL = new ProdutoDAL();
            return produtoDAL.BuscarProduto(codproduto);
        }
    }
}
