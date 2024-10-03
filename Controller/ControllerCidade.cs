using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerCidade<T> : ControllerPai<T>
    {
        protected DAOCidade<T> daoCidade;
        public ControllerCidade() : base() 
        {
            daoCidade = new DAOCidade<T>();
        }
        public override void Alterar(T obj)
        {
            daoCidade.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return daoCidade.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return daoCidade.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            daoCidade.Deletar(idObj);
        }
        public string GetNomeEstadoByCidadeId(int idCidade)
        {
            return daoCidade.GetNomeEstadoByCidadeId(idCidade);
        }
        public bool JaCadastrado(string nome, int idEstado, int idAtual)
        {
            List<ModelCidade> cidades = daoCidade.BuscarTodos(false).Cast<ModelCidade>().ToList();

            foreach (ModelCidade cidade in cidades)
            {
                if (string.Equals(cidade.Cidade, nome, StringComparison.OrdinalIgnoreCase) && cidade.idEstado == idEstado && cidade.idCidade != idAtual)
                //verifica o nome da cidade e o estado, pois podem existir cidades homônimas
                {
                    return true;
                }
            }
            return false;
        }
        public override void Salvar(T obj)
        {
            daoCidade.Salvar(obj);
        }
    }
}
