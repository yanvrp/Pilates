using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerUsuario<T> : ControllerPai<T>
    {
        protected DAOUsuario<T> usuarioDAO;

        public ControllerUsuario() : base()
        {
            usuarioDAO = new DAOUsuario<T>();
        }
        public int GetUltimoCodigo()
        {
            return usuarioDAO.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            usuarioDAO.Alterar(obj);
        }

        public override void Deletar(int idObj)
        {
            usuarioDAO.Deletar(idObj);
        }

        public override List<T> BuscarTodos(bool incluirInativos)
        {
            return usuarioDAO.BuscarTodos(incluirInativos);
        }

        public override T BuscarPorId(int idObj)
        {
            return usuarioDAO.BuscarPorId(idObj);
        }

        public override void Salvar(T obj)
        {
            usuarioDAO.Salvar(obj);
        }

        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = usuarioDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelUsuario))
            {
                var Model = obj.Cast<ModelUsuario>().ToList();

                foreach (var usuario in Model)
                {
                    if (usuario.usuario.Equals(nome, StringComparison.OrdinalIgnoreCase) && usuario.idUsuario != idAtual)
                    {
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Aviso: O tipo genérico T não é compatível.");
            }
            return false;
        }
    }
}
