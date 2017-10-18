using beloArte.BLL.ClienteBLL;
using beloArte.BLL.EnderecoBLL;
using beloArte.BLL.UsuarioBLL;
using beloArte.Domain;
using System;
using System.Web.Mvc;

namespace beloArte.UI.Controllers.Cliente
{
    public class ClienteController : Controller
    {
        private ClienteBLL clienteBLL;
        private UsuarioBLL usuarioBLL;
        private EnderecoBLL enderecoBLL;

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalvarCliente(BA_USUARIO usuario, BA_CLIENTE cliente, BA_ENDERECO endereco)
        {
            clienteBLL = new ClienteBLL();
            usuarioBLL = new UsuarioBLL();
            enderecoBLL = new EnderecoBLL();

            try
            {
                bool clienteSalvo = clienteBLL.SalvarCliente(cliente, usuario);
                bool usuarioSalvo = usuarioBLL.SalvarUsuario(usuario, cliente);
                bool enderecoSalvo = enderecoBLL.SalvarEndereco(cliente.CODCLIENTE, endereco);
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }

            return View();
        }
    }
}