using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos_Aula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //módulo de controle de botões
        private void controlesBotoes_click(object sender, EventArgs e)
        {
            if(sender == btAjuda)
                {
                MessageBox.Show("Também estou precisando de ajuda!!!","HELP");
            }
            else if(sender == btSair)
            {  
                //caso ele clique no botão sair, exibir mensagem de confirmação e armazenar em resposta.
                DialogResult resposta = MessageBox.Show("Flw","Até breve", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
                //coparando opção escolhida apos clicar no botão sair
                if (resposta == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lbX.Text = "X: " + e.X;
            lbY.Text = "Y: " + e.Y;
        }
    }
}
