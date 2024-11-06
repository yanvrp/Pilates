using Pilates.DAO;
using Pilates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public class ControllerDores<T> : ControllerPai<T>
    {
        protected DAODores<T> DoresDAO;
        public ControllerDores() : base()
        {
            DoresDAO = new DAODores<T>();
        }
        public ModelDores getDores(int id)
        { 
            return DoresDAO.getDores(id);
        }

        public int BuscarUltimoCodigo()
        {
            return DoresDAO.BuscarUltimoCodigo();
        }
        public override void Alterar(T obj)
        {
            DoresDAO.Alterar(obj);
        }

        public override T BuscarPorId(int idObj)
        {
            return DoresDAO.BuscarPorId(idObj);
        }

        public override List<T> BuscarTodos(bool BuscarInativos)
        {
            return DoresDAO.BuscarTodos(BuscarInativos);
        }

        public override void Deletar(int idObj)
        {
            DoresDAO.Deletar(idObj);
        }

        public override void Salvar(T obj)
        {
            DoresDAO.Salvar(obj);
        }
        public bool JaCadastrado(string nome, int idAtual)
        {
            List<T> obj = DoresDAO.BuscarTodos(false);

            if (typeof(T) == typeof(ModelDores))
            {
                var Model = obj.Cast<ModelDores>().ToList();

                foreach (var dores in Model)
                {
                    // Verifica se o nome já existe e não é a dor atual que está sendo alterado
                    if (dores.dores.Equals(nome, StringComparison.OrdinalIgnoreCase) && dores.idDores != idAtual)
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
