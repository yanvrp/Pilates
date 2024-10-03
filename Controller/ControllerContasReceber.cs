using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerContasReceber<T> : ControllerPai<T> where T : ModelContasReceber
    {
        protected DAOContasReceber contasReceberDAO;
        public ControllerContasReceber():base()
        {
            contasReceberDAO = new DAOContasReceber();
        }
        public override void Alterar(T obj)
        {
            contasReceberDAO.Alterar(obj);
        }
        public override T BuscarPorId(int idObj)
        {
            throw new NotImplementedException();
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            List<T> lista = new List<T>();
            var ordens = contasReceberDAO.BuscarTodos(BuscarInativos);
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
            contasReceberDAO.Salvar(obj);
        }
        public T GetContaById(int numero, int idAluno, int parcela)
        {
            return contasReceberDAO.GetContaById(numero, idAluno, parcela) as T;
        }
        public bool VerificarParcelasNaoPagas(string numeroNota, int idAluno, int parcelaAtual)
        {
            return contasReceberDAO.VerificarParcelasNaoPagas(numeroNota, idAluno, parcelaAtual);
        }
        public bool CancelarConta(T obj)
        {
            return contasReceberDAO.CancelarConta(obj);
        }
        public bool JaCadastrado(int numero, int idAluno, int parcela, bool incluindo)
        {
            List<ModelContasReceber> contasReceber = contasReceberDAO.BuscarTodos(false).Cast<ModelContasReceber>().ToList();

            foreach (ModelContasReceber conta in contasReceber)
            {
                if (conta.numero == numero &&
                    conta.idAluno == idAluno &&
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
                            conta.idAluno == idAluno &&
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
