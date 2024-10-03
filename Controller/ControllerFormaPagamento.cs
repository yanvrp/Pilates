using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerFormaPagamento<T> : ControllerPai<T>
    {
        protected DAOFormaPagamento<T> daoFormaPagamento;
        public ControllerFormaPagamento() : base()
        {
            daoFormaPagamento = new DAOFormaPagamento<T>();
        }
        public override void Alterar(T obj)
        {
            daoFormaPagamento.Alterar(obj);
        }

        public override void Deletar(int idObj)
        {
            daoFormaPagamento.Deletar(idObj);
        }

        public override List<T> BuscarTodos(bool incluiInativos)
        {
            return daoFormaPagamento.BuscarTodos(incluiInativos);
        }

        public override T BuscarPorId(int idObj)
        {
            return daoFormaPagamento.BuscarPorId(idObj);
        }

        public override void Salvar(T obj)
        {
            daoFormaPagamento.Salvar(obj);
        }

        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = daoFormaPagamento.BuscarTodos(false);

            if (typeof(T) == typeof(ModelFormaPagamento))
            {
                var Model = obj.Cast<ModelFormaPagamento>().ToList();

                foreach (var formaPag in Model)
                {
                    if (formaPag.formaPagamento.Equals(nome, StringComparison.OrdinalIgnoreCase) && formaPag.idFormaPagamento != idAtual)
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
