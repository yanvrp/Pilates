using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerDoenca<T> : ControllerPai<T>
    {
        protected DAODoenca<T> DoencaDAO;
        public ControllerDoenca() : base()
        {
            DoencaDAO = new DAODoenca<T>();
        }
        public int BuscarUltimoCodigo()
        {
            return DoencaDAO.BuscarUltimoCodigo();
        }
        public ModelDoenca getDoenca(int id)
        {
            return DoencaDAO.getDoenca(id);
        }
        public override void Alterar(T obj)
        {
            DoencaDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return DoencaDAO.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return DoencaDAO.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            DoencaDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            DoencaDAO.Salvar(obj);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = DoencaDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelDoenca))
            {
                var Model = obj.Cast<ModelDoenca>().ToList();

                foreach (var doenca in Model)
                {
                    // Verifica se o nome já existe e não é a profissao atual que está sendo alterado
                    if (doenca.doenca.Equals(nome, StringComparison.OrdinalIgnoreCase) && doenca.idDoenca != idAtual)
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
