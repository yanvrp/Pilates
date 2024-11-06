using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerGestacao<T> : ControllerPai<T>
    {
        protected DAOGestacao<T> GestacaoDAO;
        public ControllerGestacao() : base()
        {
            GestacaoDAO = new DAOGestacao<T>();
        }
        public int BuscarUltimoCodigo()
        {
            return GestacaoDAO.BuscarUltimoCodigo();
        }
        public ModelGestacao getGestacao(int id)
        {
            return GestacaoDAO.getGestacao(id);
        }
        public override void Alterar(T obj)
        {
            GestacaoDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return GestacaoDAO.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return GestacaoDAO.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            GestacaoDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            GestacaoDAO.Salvar(obj);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = GestacaoDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelGestacao))
            {
                var Model = obj.Cast<ModelGestacao>().ToList();

                foreach (var gestacao in Model)
                {
                    // Verifica se o nome já existe e não é a profissao atual que está sendo alterado
                    if (gestacao.gestacao.Equals(nome, StringComparison.OrdinalIgnoreCase) && gestacao.idGestacao != idAtual)
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
