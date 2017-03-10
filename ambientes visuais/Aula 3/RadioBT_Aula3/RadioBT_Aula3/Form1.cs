using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBT_Aula3
{
    public partial class Form1 : Form
    {
        //Declara como atributo um tipo de botão e um ícone.
        private MessageBoxButtons tipoBotao = MessageBoxButtons.OK;
        private MessageBoxIcon tipoIcone = MessageBoxIcon.Error;

        public Form1()
        {
            InitializeComponent();
        }
        
        //COMO FAZER ISSO COM CASE?
        //Método tipo de botão
        private void tipoBotao_CheckedChanged(object sender, EventArgs e)
        {
            if (sender==rbtOk)
            {
                tipoBotao = MessageBoxButtons.OK;
            } else
                if(sender==rbtOkCancelar)
                 {
                    tipoBotao = MessageBoxButtons.OKCancel;
                 }else
                    if (sender == rbtAnularRepetirCancelar)
                    {
                        tipoBotao = MessageBoxButtons.AbortRetryIgnore;
                     } else
                        if (sender==rbtSimNaoCancelar)
                        {
                            tipoBotao = MessageBoxButtons.YesNoCancel;
                        }else
                            if(sender==rbtSimNao)
                            {
                                tipoBotao = MessageBoxButtons.YesNo;
                            }else
                                    tipoBotao = MessageBoxButtons.RetryCancel;
        }

        private void tipoIcone_ChekedChanged(object sender, EventArgs e)
        {
            if (sender == rbtErro)
            {
                tipoIcone = MessageBoxIcon.Error;
            }
            else
                if (sender == rbtExclamacao)
            {
                tipoIcone = MessageBoxIcon.Exclamation;
            }
            else
                    if (sender == rbtInformacao)
            {
                tipoIcone = MessageBoxIcon.Information;
            }
            else
                tipoIcone = MessageBoxIcon.Question;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //módulo bt exibir
        private void button1_Click(object sender, EventArgs e)
        {
            //cria mensagem de acordo com as seleções
            DialogResult resposta = MessageBox.Show("Caixa de mensagem personalizada", "Mensagem personalizada", tipoBotao, tipoIcone);

            switch (resposta)
            {
                case DialogResult.OK:
                    lbMensagem.Text = "OK foi selecionado";
                    break;
                case DialogResult.Cancel:
                    lbMensagem.Text = "Cancelar foi selecionado";
                    break;
                case DialogResult.Abort:
                    lbMensagem.Text = "Anular foi selecionado";
                    break;
                case DialogResult.Retry:
                    lbMensagem.Text = "Repetir foi selecionado";
                    break;
                case DialogResult.Ignore:
                    lbMensagem.Text = "Ignorar foi Selecionado";
                    break;
                case DialogResult.Yes:
                    lbMensagem.Text = "Sim foi selecionado";
                    break;
                case DialogResult.No:
                    lbMensagem.Text = "Não foi selecionado";
                    break;
            }
        }
    }
}
