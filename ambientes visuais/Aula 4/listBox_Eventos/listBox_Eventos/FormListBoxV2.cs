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
    public partial class FormListBoxV2 : Form
    {
        public FormListBoxV2()
        {
            InitializeComponent();
        }

        private void txtNovoItem_KeyDown(object sender, KeyEventArgs e)
        {
            //verifica se a tecla pressionada foi o ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //recupera o texto
                //string item = txtNovoItem.Text;

                //add na lista de itens
                listaItens.Items.Add(txtNovoItem.Text);

                //limpa a caixa de texto
                txtNovoItem.Clear();

            }
        }

        private void listaItens_KeyDown(object sender, KeyEventArgs e)
        {
            //valida se a tecla pressionada foi o DELETE
            // e se existe ao menos um item seleionado
            if (e.KeyCode == Keys.Delete && listaItens.SelectedIndex != -1)
            {
                //remove todos os itens selecionados
                while (listaItens.SelectedItems.Count !=0)
                {
                    //remove o item que esta a primeira posição da seleção
                    listaItens.Items.Remove(listaItens.SelectedItems[0]);
                }
            }
        }
    }
}
