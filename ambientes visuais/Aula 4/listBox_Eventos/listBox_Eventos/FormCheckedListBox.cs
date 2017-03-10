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
    public partial class FormCheckedListBox : Form
    {
        public FormCheckedListBox()
        {
            InitializeComponent();
        }

        private void clbLivros_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //recupera o item selecionado e cenverte para string
            string item = clbLivros.SelectedItem.ToString();

            //verifica se o item esta o estao Checked
            if (e.NewValue == CheckState.Checked)
            {
                //adiona na lixtBox
                lbSelecao.Items.Add(item);
            }
            else
            {
                //remove da listbox
                lbSelecao.Items.Remove(item);
            }

        }
    }
}
