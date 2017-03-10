namespace listBox_Eventos
{
    partial class FormListBoxV1
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
            this.txtNovoItem = new System.Windows.Forms.TextBox();
            this.listaItens = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNovoItem
            // 
            this.txtNovoItem.Location = new System.Drawing.Point(50, 81);
            this.txtNovoItem.Name = "txtNovoItem";
            this.txtNovoItem.Size = new System.Drawing.Size(237, 20);
            this.txtNovoItem.TabIndex = 0;
            // 
            // listaItens
            // 
            this.listaItens.FormattingEnabled = true;
            this.listaItens.Location = new System.Drawing.Point(50, 122);
            this.listaItens.Name = "listaItens";
            this.listaItens.Size = new System.Drawing.Size(237, 147);
            this.listaItens.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(293, 122);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(293, 246);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(293, 184);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // FormListBoxV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 322);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listaItens);
            this.Controls.Add(this.txtNovoItem);
            this.Name = "FormListBoxV1";
            this.Text = "FormListBoxV1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNovoItem;
        private System.Windows.Forms.ListBox listaItens;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btRemover;
    }
}

