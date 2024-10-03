using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.Controller
{
    public abstract class ControllerPai<T>
    {     
        public abstract List<T> BuscarTodos(bool BuscarInativos);

        public abstract void Salvar(T obj);

        public abstract void Deletar(int idObj);

        public abstract void Alterar(T obj);

        public abstract T BuscarPorId(int idObj);
        
    }
}
