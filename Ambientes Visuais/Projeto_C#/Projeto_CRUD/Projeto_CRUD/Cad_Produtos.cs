using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_CRUD.Model;
using Projeto_CRUD.Util;

namespace Projeto_CRUD
{
    public partial class formCad_Produtos : Form
    {
        public formCad_Produtos()
        {
            InitializeComponent();
        }

        private void formCad_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produtos = new Produtos();
                produtos.produto = tbProduto.Text;
                produtos.qtd = int.Parse(tbQuantidade.Text);
                produtos.valor_unit = double.Parse(tbValor.Text);
               

                produtos.cad_Prod();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cadastro!" + ex.Message);
            }
        }


        private void cbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produtos fornecedorSelecionado = (Produtos)cbFornecedores.SelectedItem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbFornecedores.Items.AddRange(new[]
                {
                new Fornecedor("AmBev"),
            });

            this.cbFornecedores.SelectedItem = "AmBev"; // tipo string não se compara com tipo Fornecedores
        }
    }
}
