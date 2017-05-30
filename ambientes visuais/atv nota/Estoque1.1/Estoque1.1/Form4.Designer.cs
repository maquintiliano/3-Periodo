namespace Estoque1._1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvoltarp = new System.Windows.Forms.Button();
            this.btnatualizarp = new System.Windows.Forms.Button();
            this.btnexcluirp = new System.Windows.Forms.Button();
            this.btnconsultarp = new System.Windows.Forms.Button();
            this.btncadastrarp = new System.Windows.Forms.Button();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.cbforn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqtde = new System.Windows.Forms.MaskedTextBox();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvoltarp
            // 
            this.btnvoltarp.Location = new System.Drawing.Point(76, 311);
            this.btnvoltarp.Name = "btnvoltarp";
            this.btnvoltarp.Size = new System.Drawing.Size(75, 23);
            this.btnvoltarp.TabIndex = 49;
            this.btnvoltarp.Text = "VOLTAR";
            this.btnvoltarp.UseVisualStyleBackColor = true;
            this.btnvoltarp.Click += new System.EventHandler(this.btnvoltarp_Click);
            // 
            // btnatualizarp
            // 
            this.btnatualizarp.Location = new System.Drawing.Point(119, 276);
            this.btnatualizarp.Name = "btnatualizarp";
            this.btnatualizarp.Size = new System.Drawing.Size(84, 23);
            this.btnatualizarp.TabIndex = 48;
            this.btnatualizarp.Text = "ATUALIZAR";
            this.btnatualizarp.UseVisualStyleBackColor = true;
            this.btnatualizarp.Click += new System.EventHandler(this.btnatualizarp_Click);
            // 
            // btnexcluirp
            // 
            this.btnexcluirp.Location = new System.Drawing.Point(19, 276);
            this.btnexcluirp.Name = "btnexcluirp";
            this.btnexcluirp.Size = new System.Drawing.Size(83, 23);
            this.btnexcluirp.TabIndex = 47;
            this.btnexcluirp.Text = "EXCLUIR";
            this.btnexcluirp.UseVisualStyleBackColor = true;
            this.btnexcluirp.Click += new System.EventHandler(this.btnexcluirp_Click);
            // 
            // btnconsultarp
            // 
            this.btnconsultarp.Location = new System.Drawing.Point(119, 234);
            this.btnconsultarp.Name = "btnconsultarp";
            this.btnconsultarp.Size = new System.Drawing.Size(84, 23);
            this.btnconsultarp.TabIndex = 46;
            this.btnconsultarp.Text = "CONSULTAR";
            this.btnconsultarp.UseVisualStyleBackColor = true;
            this.btnconsultarp.Click += new System.EventHandler(this.btnconsultarp_Click);
            // 
            // btncadastrarp
            // 
            this.btncadastrarp.Location = new System.Drawing.Point(19, 235);
            this.btncadastrarp.Name = "btncadastrarp";
            this.btncadastrarp.Size = new System.Drawing.Size(83, 23);
            this.btncadastrarp.TabIndex = 45;
            this.btncadastrarp.Text = "CADASTRAR";
            this.btncadastrarp.UseVisualStyleBackColor = true;
            this.btncadastrarp.Click += new System.EventHandler(this.btncadastrarp_Click);
            // 
            // dgvprod
            // 
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Location = new System.Drawing.Point(246, 55);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.Size = new System.Drawing.Size(469, 279);
            this.dgvprod.TabIndex = 44;
            this.dgvprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprod_CellContentClick);
            // 
            // cbforn
            // 
            this.cbforn.FormattingEnabled = true;
            this.cbforn.Location = new System.Drawing.Point(119, 84);
            this.cbforn.Name = "cbforn";
            this.cbforn.Size = new System.Drawing.Size(121, 21);
            this.cbforn.TabIndex = 43;
            this.cbforn.SelectedIndexChanged += new System.EventHandler(this.cbforn_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "FORNECEDOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "PRODUTOS";
            // 
            // txtqtde
            // 
            this.txtqtde.Location = new System.Drawing.Point(119, 170);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(100, 20);
            this.txtqtde.TabIndex = 40;
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(119, 118);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(100, 20);
            this.txtprod.TabIndex = 39;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(119, 144);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "VALOR UNITÁRIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "QTDE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "PRODUTO:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 360);
            this.Controls.Add(this.btnvoltarp);
            this.Controls.Add(this.btnatualizarp);
            this.Controls.Add(this.btnexcluirp);
            this.Controls.Add(this.btnconsultarp);
            this.Controls.Add(this.btncadastrarp);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.cbforn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtqtde);
            this.Controls.Add(this.txtprod);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cervejaria Marry\'s";
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltarp;
        private System.Windows.Forms.Button btnatualizarp;
        private System.Windows.Forms.Button btnexcluirp;
        private System.Windows.Forms.Button btnconsultarp;
        private System.Windows.Forms.Button btncadastrarp;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.ComboBox cbforn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtqtde;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}