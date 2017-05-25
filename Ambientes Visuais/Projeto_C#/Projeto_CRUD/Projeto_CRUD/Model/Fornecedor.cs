using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projeto_CRUD.Util;

namespace Projeto_CRUD.Model
{   
    class Fornecedor : Object
    {
        public int id_forn { get; set; }
        public string fornecedor { get; set; }

        //public List<Fornecedor> Lista()
        //{
        //    Conectadb projeto_CURD = new Conectadb();

        //    NpgsqlConnection conexao = null;

        //    try

        //    {

        //        conexao = Conectadb.getConexao();
        //        string sql = "select * from fornecedor";

        //        NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

        //        //exe a consulta e acumula o resultado em uma tabela virtual
        //        NpgsqlDataReader dr = cmd.ExecuteReader();

        //        //percorre todas as linhas e monta uma lista
        //        List<Fornecedor> listfornecedor = new List<Fornecedor>();
        //        while (dr.Read())
        //        {
        //            Fornecedor forn = new Fornecedor();
        //            forn.id_forn = Convert.ToInt16(dr["id_forn"]);
        //            forn.fornecedor = dr["fornecedor"].ToString();

        //            //add o objeto na lista
        //            listfornecedor.Add(forn);
        //        }
        //        return listfornecedor;
        //    }

        //    catch (Exception ex)
        //    {
        //        //  throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        if (conexao != null)
        //        {
        //            conexao.Close();
        //        }
        //    }

        //}
        //public override string ToString()
        //{
        //    return this.fornecedor;
        //}

        
        public Fornecedor(string forn) {
            this.fornecedor = forn;
        }
        public override string ToString() {
            return this.fornecedor;
        }



    }
}
