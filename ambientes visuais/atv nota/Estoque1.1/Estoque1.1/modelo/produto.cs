using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque1._1.util;
using Npgsql;

namespace Estoque1._1.modelo
{
    class Produto
    {
        public Fornecedor fornecedor { get; set; }
        public int id_produto { get; set; }
        public string produto { get; set; }
        public int qtd { get; set; }
        public double valor_unit { get; set; }

        public Produto()
        {

        }

        public Produto(int id_produto, string produto, int qtd, double valor_unit)
        {
            this.id_produto = id_produto;
            this.produto = produto;
            this.qtd = qtd;
            this.valor_unit = valor_unit;
        }

        public void cad_Prod()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = conectaDB.getConexao();

                string sql = "insert into produto (produto, quantidade, valor_unit) values (@produto, @quantidade, @valor_unit)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@produto", this.produto));
                cmd.Parameters.Add(new NpgsqlParameter("@quantidade", this.qtd));
                cmd.Parameters.Add(new NpgsqlParameter("@valor_unit", this.valor_unit));
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }

            }
        }

        public List<Produto> ListarP()
        {

            NpgsqlConnection conexao = null;
            try
            {
                conexao.Open();
                //conexao = ConectaDB.getConexao();

                string sql = "SELECT * FROM produto;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);


                //executa a consulta e acumula o resultado em uma tabela virtual
                NpgsqlDataReader dr = cmd.ExecuteReader();

                //percorre todas as linhas e monta uma lista
                List<Produto> listaProduto = new List<Produto>();

                while (dr.Read())
                {
                    List<Fornecedor> forn = new List<Fornecedor>();
                    Produto novoProd = new Produto();
                    novoProd.id_produto = int.Parse(dr["id_prod"].ToString());
                    novoProd.produto = dr["produto"].ToString();
                    novoProd.qtd = int.Parse(dr["quantidade"].ToString());
                    novoProd.valor_unit = Convert.ToDouble(dr["telefone"].ToString());
             
                    //add o objeto na lista
                    listaProduto.Add(novoProd);
                }
                return listaProduto;
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

        }

        public void ExcluirRegistros()
        {
            NpgsqlConnection conexao = null;
            try
            {

                {
                    //Abra a conexão com o PgSQL                  
                    conexao = conectaDB.getConexao();

                    string sql = ("Delete From produto Where id_prod = @id_prod");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                    cmd.Parameters.Add(new NpgsqlParameter("@produto", this.produto));
                    cmd.Parameters.Add(new NpgsqlParameter("@quantidade", this.qtd));
                    cmd.Parameters.Add(new NpgsqlParameter("@valor_unit", this.valor_unit));

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

                    string sql = ("Select * From fornecedor Where produto = @produto");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                    cmd.Parameters.Add(new NpgsqlParameter("@produto", this.produto));
                    cmd.Parameters.Add(new NpgsqlParameter("@quantidade", this.qtd));
                    cmd.Parameters.Add(new NpgsqlParameter("@valor_unit", this.valor_unit));

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

                    string sql = ("Update fornecedor set produto = @produto");

                    NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                    cmd.Parameters.Add(new NpgsqlParameter("@produto", this.produto));
                    cmd.Parameters.Add(new NpgsqlParameter("@quantidade", this.qtd));
                    cmd.Parameters.Add(new NpgsqlParameter("@valor_unit", this.valor_unit));

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
