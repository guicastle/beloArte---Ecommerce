

using beloArte.Domain;

namespace beloArte.DAL.EnderecoDAL
{
    public class EnderecoDAL
    {
        private Context contexto;

        public EnderecoDAL()
        {
            contexto = new Context();
        }

        public void SalvarEndereco(BA_ENDERECO endereco)
        {
            try
            {
                contexto.BA_ENDERECO.Add(endereco);
                contexto.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
