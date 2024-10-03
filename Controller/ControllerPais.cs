using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerPais<T> : ControllerPai<T>
    {
        protected DAOPais<T> PaisDAO;
        public ControllerPais() : base()
        {
            PaisDAO = new DAOPais<T>();
        }
        public override void Alterar(T obj)
        {
            PaisDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return PaisDAO.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return PaisDAO.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            PaisDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            PaisDAO.Salvar(obj);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = PaisDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelPais))
            {
                var Model = obj.Cast<ModelPais>().ToList();

                foreach (var pais in Model)
                {
                    // Verifica se o nome já existe e não é o país atual que está sendo alterado
                    if (pais.Pais.Equals(nome, StringComparison.OrdinalIgnoreCase) && pais.idPais != idAtual)
                    {
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Aviso: O tipo genérico T não é compatível.");
            }

            return false;
        }
    }
}
