using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox_Eventos
{
    public partial class FormComboBox : Form
    {
        //declara uma matriz 3 x 3 
        string[,] marca_modelo = new string[3, 3];

        public FormComboBox()
        {
            InitializeComponent();
            //chama o método
            preencheMatrizMarcaModelo();
            //chama o método
            preencheComboBoxMarca();
        }

        private void preencheMatrizMarcaModelo()
        {
            //coluna 0 - carros da Ford
            marca_modelo[0,0] = "Fiesta";
            marca_modelo[1,0] = "Edge";
            marca_modelo[2,0] = "Ka";

            //coluna 1 - carros da Fiat
            marca_modelo[0,1] = "Palio";
            marca_modelo[1,1] = "Stilo";
            marca_modelo[2,1] = "Uno";

            //coluna 2 - carros da hyunday
            marca_modelo[0, 2] = "HB20";
            marca_modelo[1, 2] = "Creta";
            marca_modelo[2, 2] = "Elantra";
        }

        private void preencheComboBoxMarca ()
        {
            cbMarca.Items.Add("Ford");
            cbMarca.Items.Add("Fiat");
            cbMarca.Items.Add("Hyunday");
        }

        private void CbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recupera o indice da seleção
            int colunaMarca = cbMarca.SelectedIndex;

            //limpa cbModelo
            CbModelo.Items.Clear();

            //atualiza com as marcas
            for (int linha = 0; linha < 3; linha++)
            {
                //add todos os modelos da marca seleionada
                CbModelo.Items.Add(marca_modelo[linha,colunaMarca]);
            }
        }
    }
}
