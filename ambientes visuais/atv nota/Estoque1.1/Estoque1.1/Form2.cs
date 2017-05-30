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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnconsultarf_Click(object sender, EventArgs e)
        {
            Form3 f5 = new Form3();

            f5.Show();
            this.Hide();
        }

        private void btncadp_Click(object sender, EventArgs e)
        {
            Form4 f5 = new Form4();

            f5.Show();
            this.Hide();
        }
    }
}
