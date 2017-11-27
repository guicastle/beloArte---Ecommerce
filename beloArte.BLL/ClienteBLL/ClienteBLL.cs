using System;
using beloArte.Domain;
using beloArte.DAL.ClienteDAL;

namespace beloArte.BLL.ClienteBLL
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL;

        public void SalvarCliente(BA_CLIENTE cliente)
        {
            try
            {
                clienteDAL = new ClienteDAL();
                cliente.SEXO = cliente.SEXO.Substring(0, 1);

                clienteDAL.SalvarCliente(cliente);
            }
            catch 
            {
                throw;
            }
        }

        public BA_CLIENTE BuscarCliente(string email, string cpf)
        {
            clienteDAL = new ClienteDAL();
            return clienteDAL.BuscarCliente(email, cpf);
        }
    }
}
