using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates.DAO
{
    public class LoginDAO
    {
        protected string connectionString;
        public LoginDAO()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public string ValidarUsuario(string usuario, string senha)
        { 
            string senhaHash = Criptografia.GerarHashSenha(senha);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ativo FROM usuarios WHERE usuario = @usuario AND senha = @senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senhaHash);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isAtivo = reader.GetBoolean(reader.GetOrdinal("ativo"));
                            return isAtivo ? "ativo" : "inativo";
                        }
                    }
                }
            }

            //retorna string vazia se usuário ou a senha estão incorretos
            return "";
        }
    }
}
