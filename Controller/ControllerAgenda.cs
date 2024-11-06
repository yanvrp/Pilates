using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerAgenda<T> : ControllerPai<T> where T : ModelAgenda
    {
        public DAOAgenda daoAgenda;
        public ControllerAgenda() : base()
        {
            daoAgenda = new DAOAgenda();
        }
        public int GetUltimoNumero()
        {
            return daoAgenda.GetUltimoCodigo();
        }
        public void CancelarAgendamento(int idAgenda)
        {
            daoAgenda.CancelarAgendamento(idAgenda);
        }
        public int ContarAlunosPorHorarioEDia(TimeSpan horario, string diaSemana)
        {
            return daoAgenda.ContarAlunosPorHorarioEDia(horario, diaSemana);
        }
        public override void Alterar(T obj)
        {
            daoAgenda.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return daoAgenda.BuscarPorId(idObj) as T;
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            List<T> lista = new List<T>();
            var condicoes = daoAgenda.BuscarTodos(BuscarInativos);
            foreach (var item in condicoes)
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
            daoAgenda.Salvar(obj);
        }
    }
}
