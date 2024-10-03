using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Pilates.DAO
{
    public abstract class DAO<T>
    {
        protected string connectionString;
        public DAO()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }
        public abstract List<T> BuscarTodos(bool BuscarInativos = false);
        public abstract void Salvar(T obj);
        public abstract void Deletar(int id);
        public abstract void Alterar(T obj);
        public abstract T BuscarPorId(int id);

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
