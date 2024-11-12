using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerContrato<T> : ControllerPai<T> where T : ModelContrato
    {
        protected DAOContrato contratoDAO;
        public ControllerContrato() : base()
        {
            contratoDAO = new DAOContrato();
        }
        public bool VerificarContratoAtivo(int idAluno)
        { 
            return contratoDAO.VerificarContratoAtivo(idAluno);
        }
        public override void Alterar(T obj)
        {
            contratoDAO.Alterar(obj);
        }
        public void GerarContratoPdf(int idContrato)
        {
            contratoDAO.GerarContratoPdf(idContrato);
        }
        public void CancelarContrato(int idContrato)
        {
            contratoDAO.CancelarContrato(idContrato);
        }

        public int GetUltimoNumero()
        {
            return contratoDAO.GetUltimoNumero();
        }
        public override T BuscarPorId(int idObj)
        {
            return contratoDAO.BuscarPorId(idObj) as T;
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            List<T> lista = new List<T>();
            var condicoes = contratoDAO.BuscarTodos(BuscarInativos);
            foreach (var item in condicoes)
            {
                lista.Add(item as T);
            }
            return lista;
        }

        public override void Deletar(int idObj)
        {
            contratoDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            contratoDAO.Salvar(obj);
        }
        public int SalvarC(T obj)
        {
            return contratoDAO.SalvarC(obj);
        }
       
    }
}
