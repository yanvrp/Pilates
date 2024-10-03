using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerEstado<T> : ControllerPai<T>
    {
        protected DAOEstado<T> daoEstado;
        public ControllerEstado() :base() 
        {
            daoEstado = new DAOEstado<T>();
        }
        public override void Alterar(T obj)
        {
            daoEstado.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return daoEstado.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return daoEstado.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            daoEstado.Deletar(idObj);
        }
        public string GetNomePaisByEstadoId(int idEstado)
        {
            return daoEstado.GetNomePaisByEstadoId(idEstado);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = daoEstado.BuscarTodos(false);

            if (typeof(T) == typeof(ModelEstado))
            {
                var Model = obj.Cast<ModelEstado>().ToList();

                foreach (var estado in Model)
                {
                    if (estado.Estado.Equals(nome, StringComparison.OrdinalIgnoreCase) && estado.idEstado != idAtual)
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
        public override void Salvar(T obj)
        {
            daoEstado.Salvar(obj);
        }
    }
}
