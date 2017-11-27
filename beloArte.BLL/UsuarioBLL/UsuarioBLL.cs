using System;
using beloArte.Domain;
using beloArte.DAL.UsuarioDAL;

namespace beloArte.BLL.UsuarioBLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL;

        public void SalvarUsuario(BA_USUARIO usuario, BA_CLIENTE cliente)
        {
            try
            {
                usuarioDAL = new UsuarioDAL();
                usuario.CODCLIENTE = cliente.CODCLIENTE;

                usuarioDAL.SalvarUsuario(usuario);
            }
            catch
            {
                throw;
            }
        }
    }
}
