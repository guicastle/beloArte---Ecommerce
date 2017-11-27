using beloArte.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beloArte.DAL.ProdutoDAL
{
    public class ProdutoDAL
    {
        private Context context;

        public ProdutoDAL()
        {
            context = new Context();
        }

        public BA_PRODUTO BuscarProduto(int codproduto)
        {
            BA_PRODUTO produto = context.BA_PRODUTO.Where(m => m.CODPRODUTO == codproduto).FirstOrDefault();

            return produto;
        }
    }
}
