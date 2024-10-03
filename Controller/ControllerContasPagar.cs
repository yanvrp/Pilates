using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerContasPagar<T> : ControllerPai<T> where T : ModelContasPagar
    {
        protected DAOContasPagar contasPagarDAO;
        public ControllerContasPagar() : base()
        {
            contasPagarDAO = new DAOContasPagar();
        }
        public override void Alterar(T obj)
        {
            contasPagarDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            throw new NotImplementedException();
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            List<T> lista = new List<T>();
            var ordens = contasPagarDAO.BuscarTodos(BuscarInativos);
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
            contasPagarDAO.Salvar(obj);
        }
        public T GetContaById(int numero, int parcela)
        {
            return contasPagarDAO.GetContaById(numero, parcela) as T;
        }
        public bool VerificarParcelasNaoPagas(string numeroNota, int parcelaAtual)
        {
            return contasPagarDAO.VerificarParcelasNaoPagas(numeroNota, parcelaAtual);
        }
        public bool CancelarConta(T obj)
        {
            return contasPagarDAO.CancelarConta(obj);
        }
        public bool JaCadastrado(int numero, int parcela, bool incluindo)
        {
            List<ModelContasPagar> contasPagar = contasPagarDAO.BuscarTodos(false).Cast<ModelContasPagar>().ToList();

            foreach (ModelContasPagar conta in contasPagar)
            {
                if (conta.numero == numero &&
                    conta.parcela == parcela)
                {
                    if (incluindo)
                    {
                        //se está incluindo, e encontrou um registro com a mesma chave, retorna true
                        return true;
                    }
                    else
                    {
                        //se está alterando, verificar se é a mesma conta que está sendo alterada
                        if (conta.numero == numero &&
                            conta.parcela == parcela)
                        {
                            //é a mesma conta que está sendo alterada, não é duplicada
                            return false;
                        }
                        else
                        {
                            //é uma conta diferente, retorna true
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
