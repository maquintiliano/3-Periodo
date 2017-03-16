using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        //coleção de obj da classe pessoa
        List<Pessoa> lista = new List<Pessoa>();

        public void exibeLista()
        {
            //nula referencia  da fonte de dados (limpa colunas)
            dgvClientes.DataSource = null;

            //exibe a lista na dgv
            dgvClientes.DataSource = lista;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            

            bool valida = true;
            if (txtNome.Text == string.Empty || dtpDataNascimento.Text == string.Empty || mtxtRG.Text == string.Empty || mtxtCPF.Text == string.Empty)
            {
                MessageBox.Show("Campo em branco!!! \nPor favor preencha todos os campos.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valida = false;
            }
            // se não houvem campos em branco 
            if (valida == true)
            {
                pessoa.Nome = txtNome.Text;
                pessoa.RG = mtxtRG.Text;
                pessoa.CPF = mtxtCPF.Text;
                pessoa.DataNascimento = dtpDataNascimento.Text;
                // 0 Masculino;  1 feminino
                if (cbSexo.SelectedIndex == 0)
                {
                    pessoa.Sexo = 'M';
                }
                else
                {
                    pessoa.Sexo = 'F';
                }



                if (rbSim.Checked)
                {
                    pessoa.NecessidadesEspeciais = true;
                }
                else
                {
                    pessoa.NecessidadesEspeciais = false;
                }

                //adiona na lista de objetos
                lista.Add(pessoa);

                //chama método
                preencherDgv();

                //chama o metodo exibir que:
                //Nula a referencia da fonte de dados (limpa colunas)
                //exibe a lista na DGV
                //exibeLista();

                //limpa campos
                limparCamposTxt();

            }

        }

        private void preencherDgv()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == 'F' ? "Feminino" : "Masculino",
                    lista[i].CPF, lista[i].RG,
                    lista[i].NecessidadesEspeciais == false ? "Não" : "Sim"
                };
                dgvClientes.Rows.Add(nova_linha);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty & dtpDataNascimento.Text == string.Empty & mtxtRG.Text == string.Empty &
                mtxtCPF.Text == string.Empty)
            {
                MessageBox.Show("Não há dados para excluir \nselecione o registro à excluir.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Confirmação para exclusão
                DialogResult resposta = MessageBox.Show("Realmente deseja excluir estes dados?", "ALERTA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    if (dgvClientes.RowCount != 0)
                    {
                        //recupera o indice da linha selecionada
                        int indiceLinha = dgvClientes.CurrentRow.Index;

                        //remove da lista
                        lista.RemoveAt(indiceLinha);

                        //chama o metodo limpa campos
                        limparCamposTxt();

                    }
                }
            }

            //chama o metodo limpa campos
             limparCamposTxt();

            //chama o metodo exibir que:
            //Nula a referencia da fonte de dados (limpa colunas)
            //exibe a lista na DGV
            //exibeLista();

           

        }

        public void limparCamposTxt()
        {
            txtNome.Text = ("");
            dtpDataNascimento.Text = ("");
            mtxtCPF.Text = ("");
            mtxtRG.Text = ("");
        }

        private void dgvPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* 
            CurrentRow - recupera a linha selecionada

            Cells[i] - idica qual celula da grid a partir de 0

            Value - Recupera o valor da célula

            ToString - converte pra string um valor.

             */

            txtNome.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            dtpDataNascimento.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            mtxtRG.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            mtxtCPF.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
