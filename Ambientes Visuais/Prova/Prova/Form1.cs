using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Locadora : Form
    {
        //declarar e instanciar um obj de veiculos
        Veiculos veiculos = new Veiculos();

        //declaração lista de obj da classe produto
        List<Veiculos> lista = new List<Veiculos>();
        public Locadora()
        {
            InitializeComponent();
        }

        private void tbCodigo_Leave(object sender, EventArgs e)
        {
            //recupera o codigo
            int codVeiculo = Convert.ToInt16(tbCodigo);

            //busca o produto pelo codigo
            Veiculos VeiculoBusca = veiculos.BuscaCod(codVeiculo);

            //verifica se o veiculo foi encontrado
            if (VeiculoBusca!= null)
            {
                lbdescicao.Text = VeiculoBusca.modelo;
                
                //chama metodo que preenche a DGV
                PreencherDGV();
            }
        }

        //preencher DGV
        private void PreencherDGV()
        {
            //limpa os valores do vetor da DGV antes de inserir os novos.
           dgvVeiculo.Rows.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                string[] nova_linha = new string[]
                {
                    lista[i].cod.ToString(),
                    lista[i].marca,
                    lista[i].modelo,
                    lista[i].valorAluguel.ToString()
                };
                dgvVeiculo.Rows.Add(nova_linha);
            }

        }
    }
}
