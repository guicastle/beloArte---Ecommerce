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
        private BA_CLIENTE clienteSalvo;

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SalvarCliente(BA_USUARIO usuario, BA_CLIENTE cliente, BA_ENDERECO endereco)
        {
            try
            {
                clienteBLL = new ClienteBLL();
                usuarioBLL = new UsuarioBLL();
                enderecoBLL = new EnderecoBLL();
                clienteSalvo = new BA_CLIENTE();

                clienteBLL.SalvarCliente(cliente);

                clienteSalvo = clienteBLL.BuscarCliente(cliente.EMAIL, cliente.CPF);
                if (clienteSalvo != null) {
                    usuarioBLL.SalvarUsuario(usuario, clienteSalvo);
                    enderecoBLL.SalvarEndereco(clienteSalvo.CODCLIENTE, endereco);
                }
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }

            return View();
        }

    }
}