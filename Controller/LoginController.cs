using Pilates.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class LoginController
    {
        protected LoginDAO loginDAO;
        public LoginController() : base()
        {
            loginDAO = new LoginDAO();
        }

        public string ValidarUsuario(string usuario, string senha)
        {
            return loginDAO.ValidarUsuario(usuario, senha);
        }
    }
}
