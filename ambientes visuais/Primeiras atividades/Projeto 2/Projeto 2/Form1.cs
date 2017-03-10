using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //evento botão calcular
            float n1 = float.Parse(txtn1.Text);
            float n2 = float.Parse(txtn2.Text);

            //recuperar seleção
            string selecao = comboBox1.Text;
            float result = 0;
            switch (selecao)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                    
            
            }
            MessageBox.Show("Calculo: " + result);
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtn1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
