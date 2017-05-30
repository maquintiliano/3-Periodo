using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque1._1.modelo;

namespace Estoque1._1.util
{
    class conectaDB
    {
        //dados de conexao
        private static string serverName = "localhost";
        private static string port = "5432";
        private static string username = "postgres";
        private static string password = "10121718";
        private static string dataBaseName = "estoque";

        public static NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0};Port={1};User id={2};Password={3};Database={4};",
                    serverName, port, username, password, dataBaseName);

                NpgsqlConnection conexao = new NpgsqlConnection(stgConexao);

                conexao.Open();

                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
