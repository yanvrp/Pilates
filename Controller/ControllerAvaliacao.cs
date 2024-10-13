using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerAvaliacao<T> : ControllerPai<T> where T : ModelAvaliacao
    {
        protected DAOAvaliacao daoAvaliacao;
        public ControllerAvaliacao() : base() 
        {
            daoAvaliacao = new DAOAvaliacao();
        }
        public override void Alterar(T obj)
        {
            throw new NotImplementedException();
        }

        public override T BuscarPorId(int idObj)
        {
            return daoAvaliacao.BuscarPorId(idObj) as T;
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            List<T> lista = new List<T>();
            var ordens = daoAvaliacao.BuscarTodos(BuscarInativos);
            foreach (var item in ordens)
            {
                lista.Add(item as T);
            }
            return lista;
        }

        public override void Deletar(int idObj)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(T obj)
        {
            daoAvaliacao.Salvar(obj as ModelAvaliacao);
        }

        public ModelDoenca BuscarDoencaPorId(int idDoenca)
        {
            return daoAvaliacao.BuscarDoencaPorId(idDoenca);
        }

        public ModelDores BuscarDoresPorId(int idDores)
        {
            return daoAvaliacao.BuscarDoresPorId(idDores);
        }

        public ModelGestacao BuscarGestacaoPorId(int idGestacao)
        {
            return daoAvaliacao.BuscarGestacaoPorId(idGestacao);
        }

        public ModelCirurgia BuscarCirurgiaPorId(int idCirurgia)
        {
            return daoAvaliacao.BuscarCirurgiaPorId(idCirurgia);
        }

        public ModelMedicamento BuscarMedicamentoPorId(int idMedicamento)
        {
            return daoAvaliacao.BuscarMedicamentoPorId(idMedicamento);
        }

    }
}
