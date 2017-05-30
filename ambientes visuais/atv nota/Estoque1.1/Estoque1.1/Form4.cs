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

namespace Estoque1._1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            preencherForn();
        }

        private void preencherForn()
        {

            Fornecedor forn = new Fornecedor();
            List<Fornecedor> lista = forn.Listar();

            foreach (var fornecedor in lista)
            {
                cbforn.Items.Add(fornecedor);
            }
        }
        private void btncadastrarp_Click(object sender, EventArgs e)
        {
            try
            {


                //cria objeto produto
                Produto objProd = new Produto();
                objProd.produto = txtprod.Text;
                objProd.qtd = int.Parse(txtqtde.Text);
                objProd.valor_unit = double.Parse(txtvalor.Text);


                //executa o método cadastrar
                objProd.cad_Prod();

                //executa o método listar
                objProd.ListarP();

                //limpa campo
                txtprod.Clear();
                txtqtde.Clear();
                txtvalor.Clear();


                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar cadastrar." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnvoltarp_Click(object sender, EventArgs e)
        {
            Form2 f5 = new Form2();

            f5.Show();
            this.Hide();
        }

        private void cbforn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fornecedor fornecedorSelecionado = (Fornecedor)cbforn.SelectedItem;
        }

        private void btnconsultarp_Click(object sender, EventArgs e)
        {
            try
            {

                //cria objeto produto
                Produto objProd = new Produto();
                objProd.produto = txtprod.Text;


                //exibir dvg
                dgvprod.DataSource = objProd.ListarP();

                //limpa campo
                txtprod.Clear();
                txtqtde.Clear();
                txtvalor.Clear();

                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar consultar." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexcluirp_Click(object sender, EventArgs e)
        {
            try
            {

                //cria objeto produto
                Produto objProd = new Produto();
                objProd.produto = txtprod.Text;

                //executa lista
                objProd.ConsultarForn();

                //executa metodo exclui
                objProd.ExcluirRegistros();

                //executa lista
                objProd.ListarP();

                //limpa campo
                txtprod.Clear();
                txtqtde.Clear();
                txtvalor.Clear();

                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnatualizarp_Click(object sender, EventArgs e)
        {
            try
            {

                //cria objeto produto
                Produto objProd = new Produto();
                objProd.produto = txtprod.Text;

                //executa lista
                objProd.ConsultarForn();

                //executa metodo exclui
                objProd.AtualizarFon();

                //executa lista
                objProd.ListarP();

                //limpa campo
                txtprod.Clear();
                txtqtde.Clear();
                txtvalor.Clear();

                MessageBox.Show("Operação realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar." + ex.Message, "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtprod.Text = Convert.ToString(dgvprod.Rows[e.RowIndex].Cells[1].Value);
            txtqtde.Text = Convert.ToString(dgvprod.Rows[e.RowIndex].Cells[2].Value);
            txtvalor.Text = Convert.ToString(dgvprod.Rows[e.RowIndex].Cells[3].Value);
        }
    }
}
