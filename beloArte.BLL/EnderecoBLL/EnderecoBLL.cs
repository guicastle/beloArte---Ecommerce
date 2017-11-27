using System;
using beloArte.Domain;
using beloArte.DAL.EnderecoDAL;

namespace beloArte.BLL.EnderecoBLL
{
    public class EnderecoBLL
    {
        private EnderecoDAL enderecoDAL;

        public void SalvarEndereco(int codCliente, BA_ENDERECO endereco)
        {
            try
            {
                enderecoDAL = new EnderecoDAL();

                endereco.CODCLIENTE = codCliente;

                enderecoDAL.SalvarEndereco(endereco);
            }
            catch
            {
                throw;
            }
        }
    }
}
