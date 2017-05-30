using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque1._1.util;
using System.Windows.Forms;

namespace Estoque1._1.modelo
{
    class Fornecedor
    {
        public int id { get; set; }
        public string fornecedor { get; set; }
        public string mercadoria { get; set; }
        public int telefone { get; set; }

        public Fornecedor() { }

        public Fornecedor(int id, string fornecedor, string mercadoria, int telefone)
        {
            this.id = id;
            this.fornecedor = fornecedor;
            this.mercadoria = mercadoria;
            this.telefone = telefone;
        }

        public void InserirRegistros()
        {
            NpgsqlConnection conexao = null;
            try
            {
                    //Abra a conexão com o PgSQL                  
                    conexao = conectaDB.getConexao();

                    string sql = ("INSERT INTO fornecedor(fornecedor,mercadoria,telefone) values(@fornecedor,@mercadoria,@telefone);");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql,conexao);

                    cmd.Parameters.Add(new NpgsqlParameter("@fornecedor", this.fornecedor));
                    cmd.Parameters.Add(new NpgsqlParameter("@mercadoria", this.mercadoria));
                    cmd.Parameters.Add(new NpgsqlParameter("@telefone", this.telefone));

                    cmd.ExecuteNonQuery();

                    
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<Fornecedor> Listar()
        {
            List<Fornecedor> lista = new List<Fornecedor>();
            NpgsqlConnection conexao = null;

            try
            {

                conexao = conectaDB.getConexao();
                string sql = "select * from fornecedor";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                //exe a consulta e acumula o resultado em uma tabela virtual
                NpgsqlDataReader dr = cmd.ExecuteReader();

                //percorre todas as linhas e monta uma lista
                while (dr.Read())
                {
                    Fornecedor forn = new Fornecedor();
                    forn.id = Convert.ToInt16(dr["id_forn"]);
                    forn.fornecedor = dr["fornecedor"].ToString();
                    forn.mercadoria = dr["mercadoria"].ToString();
                    forn.telefone = int.Parse(dr["telefone"].ToString());

                    //add o objeto na lista
                    lista.Add(forn);
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return lista;
        }

        public void ExcluirRegistros()
        {
            NpgsqlConnection conexao = null;
            try
            {

                {
                    //Abra a conexão com o PgSQL                  
                    conexao = conectaDB.getConexao();

                    string sql = ("Delete From fornecedor Where id_forn = @id_forn;");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                    cmd.Parameters.Add(new NpgsqlParameter("@fornecedor", this.fornecedor));
                    cmd.Parameters.Add(new NpgsqlParameter("@mercadoria", this.mercadoria));
                    cmd.Parameters.Add(new NpgsqlParameter("@telefone", this.telefone));

                    cmd.ExecuteNonQuery();


                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ConsultarForn()
        {
            NpgsqlConnection conexao = null;
            try
            {

                {
                    //Abra a conexão com o PgSQL                  
                    conexao = conectaDB.getConexao();

                    string sql = ("Select * From fornecedor Where fornecedor = @fornecedor;");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                    cmd.Parameters.Add(new NpgsqlParameter("@fornecedor", this.fornecedor));
                    cmd.Parameters.Add(new NpgsqlParameter("@mercadoria", this.mercadoria));
                    cmd.Parameters.Add(new NpgsqlParameter("@telefone", this.telefone));

                    cmd.ExecuteNonQuery();


                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void AtualizarFon()
        {
            NpgsqlConnection conexao = null;
            try
            {

                {
                    //Abra a conexão com o PgSQL                  
                    conexao = conectaDB.getConexao();

                    string sql = ("Update fornecedor set id_forn = @id_forn;");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                    cmd.Parameters.Add(new NpgsqlParameter("@fornecedor", this.fornecedor));
                    cmd.Parameters.Add(new NpgsqlParameter("@mercadoria", this.mercadoria));
                    cmd.Parameters.Add(new NpgsqlParameter("@telefone", this.telefone));

                    cmd.ExecuteNonQuery();


                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }
    }

}


