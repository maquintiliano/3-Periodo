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


        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void preencherDgv()
        {
            //limpar DGV
            dgvClientes.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].Nome,
                    lista[i].DataNascimento,
                    lista[i].Sexo == "F" ? "Feminino" : "Masculino",
                    lista[i].CPF, lista[i].RG,
                    lista[i].NecessidadesEspeciais == false ? "Não" : "Sim"
                };
                dgvClientes.Rows.Add(nova_linha);
            }
        }
    }
}
