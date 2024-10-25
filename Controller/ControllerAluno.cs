using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerAluno<T> : ControllerPai<T>
    {
        protected DAOAluno<T> daoAluno;
        public ControllerAluno() : base()
        {
            daoAluno = new DAOAluno<T>();
        }
        public override void Alterar(T obj)
        {
            daoAluno.Alterar(obj);
        }
        public int BuscarUltimoCodigo()
        {
            return daoAluno.BuscarUltimoCodigo();
        }

        public override T BuscarPorId(int idObj)
        {
            return daoAluno.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return daoAluno.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            daoAluno.Deletar(idObj);
        }
         
        public List<string> GetCEPByCidadeId(int idCidade)
        {
            return daoAluno.GetCEPByCidadeId(idCidade);
        }
        public override void Salvar(T obj)
        {
            daoAluno.Salvar(obj);
        }
        public List<ModelPostura> GetPosturasPorAlunoID(int IDAluno)
        {
            return daoAluno.GetPosturasPorAlunoID(IDAluno);
        }
        public List<ModelEvolucao> GetEvolucaoPorAlunoID(int IDAluno)
        {
            return daoAluno.GetEvolucaoPorAlunoID(IDAluno);
        }
        public bool JaCadastrado(string cpf, int idAtual)
        {
            List<ModelAluno> alunos = daoAluno.BuscarTodos(false).Cast<ModelAluno>().ToList();
            if(string.IsNullOrEmpty(cpf))
                return false;
            foreach (ModelAluno aluno in alunos)
            {
                if (string.Equals(aluno.cpf, cpf, StringComparison.OrdinalIgnoreCase) && aluno.idAluno != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
