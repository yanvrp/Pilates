using Pilates.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerPostura<T> : ControllerPai<T>
    {
        protected DAOPostura<T> daoPostura;
        public ControllerPostura() : base()
        {
            daoPostura = new DAOPostura<T>();
        }
        public override void Alterar(T obj)
        {
            daoPostura.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return daoPostura.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return daoPostura.BuscarTodos(BuscarInativos);
        }
        public string GetNomeAlunoByPosturaId(int idPostura)
        {
            return daoPostura.GetNomeAlunoByPosturaId(idPostura);
        }
        public string GetNomeAlunoByAlunoID(int idAluno)
        {
            return daoPostura.GetNomeAlunoByAlunoId(idAluno);
        }
        public override void Deletar(int idObj)
        {
            daoPostura.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            daoPostura.Salvar(obj);
        }
    }
}
