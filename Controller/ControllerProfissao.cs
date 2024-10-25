using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerProfissao<T> : ControllerPai<T>
    {
        protected DAOProfissao<T> ProfissaoDAO;
        public ControllerProfissao() : base()
        {
            ProfissaoDAO = new DAOProfissao<T>();
        }
        public int BuscarUltimoCodigo()
        {
            return ProfissaoDAO.BuscarUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            ProfissaoDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return ProfissaoDAO.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return ProfissaoDAO.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            ProfissaoDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            ProfissaoDAO.Salvar(obj);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = ProfissaoDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelProfissao))
            {
                var Model = obj.Cast<ModelProfissao>().ToList();

                foreach (var profissao in Model)
                {
                    // Verifica se o nome já existe e não é a profissao atual que está sendo alterado
                    if (profissao.profissao.Equals(nome, StringComparison.OrdinalIgnoreCase) && profissao.idProfissao != idAtual)
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
