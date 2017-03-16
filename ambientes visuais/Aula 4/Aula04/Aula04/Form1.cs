using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04
{
    public partial class Form1 : Form
    {
        //declaração lista de objetos da classe pessoa
        List<Pessoa> lista = new List<Pessoa>();

        //metodo de lista na DGV
        public void exibeLista()
        {
            //nula referencia  da fonte de dados (limpa colunas)
            dgvPessoas.DataSource = null;

            //exibe a lista na dgv
            dgvPessoas.DataSource = lista;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            //Recupera os valores dos campos de texto e atribui ao objeto
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.dataNascimento = txtDataNascimento.Text;
            p.cpf = txtCpf.Text;
            p.rg = txtRg.Text;

            //validando entrada em branco
            bool valida = true;
            if (txtNome.Text == string.Empty | txtDataNascimento.Text == string.Empty | txtRg.Text == string.Empty | txtCpf.Text == string.Empty)
            {
                MessageBox.Show("Campo em branco!!! \nPor favor preencha todos os campos.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valida = false;
            }

            // se não houvem campos em branco 
            if (valida == true)
            {
                //adiona o objeto na lista (adiona a referencia ao objeto a lista)
                lista.Add(p);

                //chama o metodo exibir que:
                //Nula a referencia da fonte de dados (limpa colunas)
                //exibe a lista na DGV
                exibeLista();

                //limpa campos
                limparCamposTxt();
            }
        }

        public void limparCamposTxt()
        {
            txtNome.Text = ("");
            txtDataNascimento.Text = ("");
            txtCpf.Text = ("");
            txtRg.Text = ("");
        }

        private void dgvPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* 
            CurrentRow - recupera a linha selecionada

            Cells[i] - idica qual celula da grid a partir de 0

            Value - Recupera o valor da célula

            ToString - converte pra string um valor.

             */

            txtNome.Text = dgvPessoas.CurrentRow.Cells[0].Value.ToString();
            txtDataNascimento.Text = dgvPessoas.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvPessoas.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvPessoas.CurrentRow.Cells[3].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //verifica se há dados para excluir
            if (txtNome.Text == string.Empty & txtDataNascimento.Text == string.Empty & txtRg.Text == string.Empty & txtCpf.Text == string.Empty)
            {
                MessageBox.Show("Não há dados para excluir \nselecione o registro à excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Confirmação para exclusão
                DialogResult resposta = MessageBox.Show("Realmente deseja excluir estes dados?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    if (dgvPessoas.RowCount != 0 )
                    {
                        //recupera o indice da linha selecionada
                        int indiceLinha = dgvPessoas.CurrentRow.Index;

                        //remove da lista
                        lista.RemoveAt(indiceLinha);

                       

                    }       
                }
            }
            

            //chama o metodo limpa campos
            limparCamposTxt();

            //chama o metodo exibir que:
            //Nula a referencia da fonte de dados (limpa colunas)
            //exibe a lista na DGV
            exibeLista();



        }
    }
}
