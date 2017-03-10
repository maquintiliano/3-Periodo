using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Aula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckNegao_CheckedChanged(object sender, EventArgs e)
        {
            lbMudandoTexto.Font = new Font(lbMudandoTexto.Font.Name,
                  lbMudandoTexto.Font.Size,
                  lbMudandoTexto.Font.Style ^ FontStyle.Bold);
        }

        private void CheckIta_CheckedChanged(object sender, EventArgs e)
        {
            lbMudandoTexto.Font = new Font(lbMudandoTexto.Font.Name,
                  lbMudandoTexto.Font.Size,
                  lbMudandoTexto.Font.Style ^ FontStyle.Italic);
        }

        private void checkSub_CheckedChanged(object sender, EventArgs e)
        {
            lbMudandoTexto.Font = new Font(lbMudandoTexto.Font.Name,
                  lbMudandoTexto.Font.Size,
                  lbMudandoTexto.Font.Style ^ FontStyle.Underline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
