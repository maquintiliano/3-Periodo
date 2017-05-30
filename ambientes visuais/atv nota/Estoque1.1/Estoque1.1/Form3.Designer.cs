namespace Estoque1._1
{
    partial class Form3
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
            this.btnvoltarf = new System.Windows.Forms.Button();
            this.btncadf = new System.Windows.Forms.Button();
            this.btnatualizarf = new System.Windows.Forms.Button();
            this.btnexcluirf = new System.Windows.Forms.Button();
            this.btnconsultarf = new System.Windows.Forms.Button();
            this.dgvForn = new System.Windows.Forms.DataGridView();
            this.tbmerc = new System.Windows.Forms.TextBox();
            this.tbfor = new System.Windows.Forms.TextBox();
            this.tbtelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvoltarf
            // 
            this.btnvoltarf.Location = new System.Drawing.Point(149, 235);
            this.btnvoltarf.Name = "btnvoltarf";
            this.btnvoltarf.Size = new System.Drawing.Size(75, 23);
            this.btnvoltarf.TabIndex = 47;
            this.btnvoltarf.Text = "VOLTAR";
            this.btnvoltarf.UseVisualStyleBackColor = true;
            this.btnvoltarf.Click += new System.EventHandler(this.btnvoltarf_Click);
            // 
            // btncadf
            // 
            this.btncadf.Location = new System.Drawing.Point(33, 235);
            this.btncadf.Name = "btncadf";
            this.btncadf.Size = new System.Drawing.Size(100, 23);
            this.btncadf.TabIndex = 46;
            this.btncadf.Text = "CADASTRAR";
            this.btncadf.UseVisualStyleBackColor = true;
            this.btncadf.Click += new System.EventHandler(this.btncadf_Click);
            // 
            // btnatualizarf
            // 
            this.btnatualizarf.Location = new System.Drawing.Point(180, 196);
            this.btnatualizarf.Name = "btnatualizarf";
            this.btnatualizarf.Size = new System.Drawing.Size(75, 23);
            this.btnatualizarf.TabIndex = 45;
            this.btnatualizarf.Text = "Atualizar";
            this.btnatualizarf.UseVisualStyleBackColor = true;
            this.btnatualizarf.Click += new System.EventHandler(this.btnatualizarf_Click);
            // 
            // btnexcluirf
            // 
            this.btnexcluirf.Location = new System.Drawing.Point(98, 196);
            this.btnexcluirf.Name = "btnexcluirf";
            this.btnexcluirf.Size = new System.Drawing.Size(75, 23);
            this.btnexcluirf.TabIndex = 44;
            this.btnexcluirf.Text = "Excluir";
            this.btnexcluirf.UseVisualStyleBackColor = true;
            this.btnexcluirf.Click += new System.EventHandler(this.btnexcluirf_Click);
            // 
            // btnconsultarf
            // 
            this.btnconsultarf.Location = new System.Drawing.Point(17, 196);
            this.btnconsultarf.Name = "btnconsultarf";
            this.btnconsultarf.Size = new System.Drawing.Size(75, 23);
            this.btnconsultarf.TabIndex = 43;
            this.btnconsultarf.Text = "Consultar";
            this.btnconsultarf.UseVisualStyleBackColor = true;
            this.btnconsultarf.Click += new System.EventHandler(this.btnconsultarf_Click);
            // 
            // dgvForn
            // 
            this.dgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForn.Location = new System.Drawing.Point(265, 12);
            this.dgvForn.Name = "dgvForn";
            this.dgvForn.Size = new System.Drawing.Size(383, 228);
            this.dgvForn.TabIndex = 42;
            this.dgvForn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvForn_CellContentClick);
            // 
            // tbmerc
            // 
            this.tbmerc.Location = new System.Drawing.Point(102, 105);
            this.tbmerc.Name = "tbmerc";
            this.tbmerc.Size = new System.Drawing.Size(100, 20);
            this.tbmerc.TabIndex = 41;
            // 
            // tbfor
            // 
            this.tbfor.Location = new System.Drawing.Point(102, 57);
            this.tbfor.Name = "tbfor";
            this.tbfor.Size = new System.Drawing.Size(100, 20);
            this.tbfor.TabIndex = 40;
            // 
            // tbtelefone
            // 
            this.tbtelefone.Location = new System.Drawing.Point(102, 152);
            this.tbtelefone.Name = "tbtelefone";
            this.tbtelefone.Size = new System.Drawing.Size(100, 20);
            this.tbtelefone.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 54);
            this.label4.TabIndex = 38;
            this.label4.Text = "\r\nFORNECEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "TELEFONE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "MERCADORIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "NOME:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 281);
            this.Controls.Add(this.btnvoltarf);
            this.Controls.Add(this.btncadf);
            this.Controls.Add(this.btnatualizarf);
            this.Controls.Add(this.btnexcluirf);
            this.Controls.Add(this.btnconsultarf);
            this.Controls.Add(this.dgvForn);
            this.Controls.Add(this.tbmerc);
            this.Controls.Add(this.tbfor);
            this.Controls.Add(this.tbtelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cervejaria Marry\'s";
            ((System.ComponentModel.ISupportInitialize)(this.dgvForn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltarf;
        private System.Windows.Forms.Button btncadf;
        private System.Windows.Forms.Button btnatualizarf;
        private System.Windows.Forms.Button btnexcluirf;
        private System.Windows.Forms.Button btnconsultarf;
        private System.Windows.Forms.DataGridView dgvForn;
        private System.Windows.Forms.TextBox tbmerc;
        private System.Windows.Forms.TextBox tbfor;
        private System.Windows.Forms.MaskedTextBox tbtelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}