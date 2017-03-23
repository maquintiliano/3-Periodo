using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class Form1 : Form
    {
        //declara e instancia um objeto produto
        Produto produto = new Produto();

        public Form1()
        {
            InitializeComponent();
        }

        //evento
        private void txtCodigo_Leave(object sender, EventArgs e)
        {

            //recupera o código
            int codigo = int.Parse(txtCodigo.Text);

            //busca por codigo
            Produto produtoBusca = produto.buscaPorCodigo(codigo);

            //verifica se foi encontrado
            if (produtoBusca != null)
            {
                lbProduto.Text = produtoBusca.Descricao;
                txtPreco.Text = produtoBusca.PrecoUnitario.ToString("C");
                txtQtd.Text = Convert.ToString(produtoBusca.Qtd);
            }

            //exibe os produtos 

        }
    }
}
