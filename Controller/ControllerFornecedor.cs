using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerFornecedor<T> : ControllerPai<T>
    {
        protected DAOFornecedor<T> DAOFornecedor;
        public ControllerFornecedor() : base() 
        {
            DAOFornecedor = new DAOFornecedor<T>();
        }

        public int GetUltimoCodigo()
        {
            return DAOFornecedor.GetUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            DAOFornecedor.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return DAOFornecedor.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return DAOFornecedor.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            DAOFornecedor.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            DAOFornecedor.Salvar(obj);
        }
        public List<string> GetCEPByIdCidade(int idCidade)
        {
            return DAOFornecedor.GetCEPByIdCidade(idCidade);
        }
        public bool JaCadastrado(string cpf_cnpj, int idAtual)
        {
            if (string.IsNullOrEmpty(cpf_cnpj))
                return false;
            List<ModelFornecedor> fornecedores = DAOFornecedor.BuscarTodos(false).Cast<ModelFornecedor>().ToList();

            foreach (ModelFornecedor fornecedor in fornecedores)
            {
                if (string.Equals(fornecedor.cpf_cnpj, cpf_cnpj, StringComparison.OrdinalIgnoreCase) && fornecedor.idFornecedor != idAtual)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
