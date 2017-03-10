using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox_Eventos
{
    public partial class FormListBoxV1 : Form
    {
        public FormListBoxV1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Recupera o texto
            string item = txtNovoItem.Text;

            //add na list box
            listaItens.Items.Add(item);

            //limpa a caixa de texto
            txtNovoItem.Clear();

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            //verifica se existe ao menos um item selecionado
            if (listaItens.SelectedIndex != -1)
            {
                //remove o item passado pelo indice
                listaItens.Items.RemoveAt(listaItens.SelectedIndex);
            }
            else
            {   //envia mensagem se nada for selecionado
                MessageBox.Show("Selecione um item","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            listaItens.Items.Clear();
        }
    }
}
