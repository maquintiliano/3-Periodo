using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos_Mouse
{
    public partial class Form1 : Form
    {
        /*
         Atributo do formulário 
         utilizando como flag para controlar
         quando dever pintar
         */
        bool devePintar = false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (devePintar)
            {
                //Cria um do grapics do forulario
                Graphics grapics = CreateGraphics();
                grapics.FillEllipse(new SolidBrush(Color.DarkRed), e.X, e.Y, 10, 10);
            }
        }//fim do evento

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            devePintar = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            devePintar = false;
            
        }

        private void btClean_Click(object sender, EventArgs e)
        {

            //limpando o form, usando duas cores para q limpe sempre que clicado!
            this.BackColor = System.Drawing.Color.Red;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
         }

    private void btExit_Click(object sender, EventArgs e)
        {
            //caso ele clique no botão sair, exibir mensagem de confirmação e armazenar em resposta.
            DialogResult resp = MessageBox.Show("Deseja sair?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
