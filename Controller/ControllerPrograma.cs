using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerPrograma<T> : ControllerPai<T>
    {
        protected DAOPrograma<T> daoPrograma;
        public ControllerPrograma() : base()
        {
            daoPrograma = new DAOPrograma<T>();
        }
        public ModelPrograma getPrograma(int id)
        {
            return daoPrograma.getPrograma(id);
        }
        public override void Alterar(T obj)
        {
            daoPrograma.Alterar(obj);
        }
        public int BuscarUltimoCodigo()
        {
            return daoPrograma.BuscarUltimoCodigo();
        }

        public override T BuscarPorId(int idObj)
        {
            return daoPrograma.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return daoPrograma.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            daoPrograma.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            daoPrograma.Salvar(obj);
        }
    }
}
