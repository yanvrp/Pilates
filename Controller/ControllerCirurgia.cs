using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerCirurgia<T> : ControllerPai<T>
    {
        protected DAOCirurgia<T> CirurgiaDAO;
        public ControllerCirurgia() : base()
        {
            CirurgiaDAO = new DAOCirurgia<T>();
        }
        public override void Alterar(T obj)
        {
            CirurgiaDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return CirurgiaDAO.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return CirurgiaDAO.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            CirurgiaDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            CirurgiaDAO.Salvar(obj);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = CirurgiaDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelCirurgia))
            {
                var Model = obj.Cast<ModelCirurgia>().ToList();

                foreach (var cirurgia in Model)
                {
                    // Verifica se o nome já existe e não é a profissao atual que está sendo alterado
                    if (cirurgia.cirurgia.Equals(nome, StringComparison.OrdinalIgnoreCase) && cirurgia.idCirurgia != idAtual)
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
