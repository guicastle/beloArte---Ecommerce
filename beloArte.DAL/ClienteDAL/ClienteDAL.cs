using beloArte.Domain;
using System;
using System.Linq;

namespace beloArte.DAL.ClienteDAL
{
    public class ClienteDAL
    {
        private Context contexto;

        public ClienteDAL()
        {
            contexto = new Context();
        }
        
        public void SalvarCliente(BA_CLIENTE cliente)
        {
            try
            {
                contexto.BA_CLIENTE.Add(cliente);
                contexto.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public BA_CLIENTE BuscarCliente(string email, string cpf)
        {                
            return contexto.BA_CLIENTE.Where(m => m.EMAIL == email && m.CPF == cpf).FirstOrDefault();
        }
    }
}
