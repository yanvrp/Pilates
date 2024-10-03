using Pilates.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerEvolucao<T> : ControllerPai<T>
    {
        protected DAOEvolucao<T> daoEvolucao;
        public ControllerEvolucao() : base()
        {
            daoEvolucao = new DAOEvolucao<T>();
        }
        public override void Alterar(T obj)
        {
            daoEvolucao.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return daoEvolucao.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return daoEvolucao.BuscarTodos(BuscarInativos);
        }
        public string GetNomeAlunoByEvolucaoId(int idEvolucao)
        {
            return daoEvolucao.GetNomeAlunoByEvolucaoId(idEvolucao);
        }
        public string GetNomeAlunoByAlunoID(int idAluno)
        {
            return daoEvolucao.GetNomeAlunoByAlunoId(idAluno);
        }
        public override void Deletar(int idObj)
        {
            daoEvolucao.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            daoEvolucao.Salvar(obj);
        }
    }
}
