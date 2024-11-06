using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    internal class ControllerCondicaoPagamento<T> : ControllerPai<T> where T : ModelCondicaoPagamento
    {
        protected DAOCondicaoPagamento daoCondicaoPagamento;
        public ControllerCondicaoPagamento() : base()
        {
            daoCondicaoPagamento = new DAOCondicaoPagamento();
        }
        public int BuscarUltimoCodigo()
        {
            return daoCondicaoPagamento.BuscarUltimoCodigo();
        }
        public string getCondicaoPag(int id)
        {
            return daoCondicaoPagamento.getCondicaoPag(id);
        }
        public override void Alterar(T obj)
        {
            daoCondicaoPagamento.Alterar(obj as ModelCondicaoPagamento);
        }

        public override void Deletar(int idObj)
        {
            daoCondicaoPagamento.Deletar(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            List<T> lista = new List<T>();
            var condicoes = daoCondicaoPagamento.BuscarTodos(BuscarInativos);
            foreach (var item in condicoes)
            {
                lista.Add(item as T);
            }
            return lista;
        }

        public override T BuscarPorId(int idObj)
        {
            return daoCondicaoPagamento.BuscarPorId(idObj) as T;
        }

        public string GetFormaPagByParcelaId(int idParcela)
        {
            return daoCondicaoPagamento.GetFormaPagByParcelaId(idParcela);
        }

        public override void Salvar(T obj)
        {
            daoCondicaoPagamento.Salvar(obj as ModelCondicaoPagamento);
        }
    }
}
