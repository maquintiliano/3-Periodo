using Estoque1._1.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estoque1._1.util;

namespace Estoque1._1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        //BOTÃO CADASTRAR
        private void btncadf_Click(object sender, EventArgs e)
        {
            try
            {
                

                //cria objeto produto
                Fornecedor objForn = new Fornecedor();
                objForn.fornecedor = tbfor.Text;
                objForn.mercadoria = tbmerc.Text;
                objForn.telefone = int.Parse(tbtelefone.Text);

                //executa o método cadastrar
                objForn.InserirRegistros();

                //executa o método listar
                 objForn.Listar();

                //limpa campo
                tbfor.Clear();
                tbmerc.Clear();
                tbtelefone.Clear();

                tbfor.Focus();


                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar cadastrar." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //BOTÃO CONSULTAR
        private void btnconsultarf_Click(object sender, EventArgs e)
        {

            try
            {

                //recuperar 
                
                //cria objeto produto
                Fornecedor objForn = new Fornecedor();
                objForn.fornecedor = tbfor.Text;

                //exibir dvg
                dgvForn.DataSource = objForn.Listar();

                //limpa campo
                tbfor.Clear();
                tbmerc.Clear();
                tbtelefone.Clear();

                tbfor.Focus();

                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar consultar." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //BOTÃO EXCLUIR
        private void btnexcluirf_Click(object sender, EventArgs e)
        {
            try
            {
                
                //cria objeto produto
                Fornecedor objForn = new Fornecedor();

                //executa lista
                objForn.ConsultarForn();

                //executa metodo exclui
                objForn.ExcluirRegistros();

                //executa lista
                objForn.Listar();

                //limpa campo
                tbfor.Clear();
                tbmerc.Clear();
                tbtelefone.Clear();

                tbfor.Focus();

                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvForn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tbfor.Text = Convert.ToString(dgvForn.Rows[e.RowIndex].Cells[1].Value);
            tbmerc.Text = Convert.ToString(dgvForn.Rows[e.RowIndex].Cells[2].Value);
            tbtelefone.Text = Convert.ToString(dgvForn.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnvoltarf_Click(object sender, EventArgs e)
        {
            Form2 f5 = new Form2();

            f5.Show();
            this.Hide();
        }

        //BOTÃO ATUALIZAR
        private void btnatualizarf_Click(object sender, EventArgs e)
        {
            try
            {

                //cria objeto produto
                Fornecedor objForn = new Fornecedor();

                //executa lista
                objForn.ConsultarForn();

                //executa metodo exclui
                objForn.AtualizarFon();

                //executa lista
                objForn.Listar();

                //limpa campo
                tbfor.Clear();
                tbmerc.Clear();
                tbtelefone.Clear();

                tbfor.Focus();

                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    
