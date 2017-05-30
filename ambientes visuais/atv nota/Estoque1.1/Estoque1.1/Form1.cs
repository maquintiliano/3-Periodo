using Npgsql;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            bool blnfound = false;

            NpgsqlConnection conn = new NpgsqlConnection("server=localhost;port=5432; user Id= postgres; Password=10121718;dataBase=estoque");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select*from cadastro where usuario = '" + txtlogin.Text + "' and senha='" + txtsenha.Text + "'", conn);
            DataTable dt = new DataTable();
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                blnfound = true;
                Form2 f5 = new Form2();

                f5.Show();
                this.Hide();

            }
            if (blnfound == false)
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }




        }
    }
}
