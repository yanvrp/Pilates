using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerMedicamento<T> : ControllerPai<T>
    {
        protected DAOMedicamento<T> MedicamentoDAO;
        public ControllerMedicamento() : base()
        {
            MedicamentoDAO = new DAOMedicamento<T>();
        }
        public override void Alterar(T obj)
        {
            MedicamentoDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return MedicamentoDAO.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return MedicamentoDAO.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            MedicamentoDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            MedicamentoDAO.Salvar(obj);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = MedicamentoDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelMedicamento))
            {
                var Model = obj.Cast<ModelMedicamento>().ToList();

                foreach (var medicamento in Model)
                {
                    // Verifica se o nome já existe e não é o medicamento atual que está sendo alterado
                    if (medicamento.medicamento.Equals(nome, StringComparison.OrdinalIgnoreCase) && medicamento.idMedicamento != idAtual)
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
