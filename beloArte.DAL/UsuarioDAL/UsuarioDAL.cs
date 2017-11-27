using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beloArte.Domain;

namespace beloArte.DAL.UsuarioDAL
{
    public class UsuarioDAL
    {
        private Context contexto;

        public UsuarioDAL()
        {
            contexto = new Context();
        }

        public void SalvarUsuario(BA_USUARIO usuario)
        {
            try
            {
                contexto.BA_USUARIO.Add(usuario);
                contexto.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
