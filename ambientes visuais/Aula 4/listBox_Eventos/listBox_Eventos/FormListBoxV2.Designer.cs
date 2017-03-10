namespace listBox_Eventos
{
    partial class FormListBoxV2
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
            this.lbEnter = new System.Windows.Forms.Label();
            this.txtNovoItem = new System.Windows.Forms.TextBox();
            this.listaItens = new System.Windows.Forms.ListBox();
            this.lbRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEnter
            // 
            this.lbEnter.AutoSize = true;
            this.lbEnter.Location = new System.Drawing.Point(26, 21);
            this.lbEnter.Name = "lbEnter";
            this.lbEnter.Size = new System.Drawing.Size(189, 13);
            this.lbEnter.TabIndex = 0;
            this.lbEnter.Text = "Digite o nove item e pressione ENTER";
            // 
            // txtNovoItem
            // 
            this.txtNovoItem.Location = new System.Drawing.Point(29, 38);
            this.txtNovoItem.Name = "txtNovoItem";
            this.txtNovoItem.Size = new System.Drawing.Size(186, 20);
            this.txtNovoItem.TabIndex = 1;
            this.txtNovoItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoItem_KeyDown);
            // 
            // listaItens
            // 
            this.listaItens.FormattingEnabled = true;
            this.listaItens.Location = new System.Drawing.Point(29, 66);
            this.listaItens.Name = "listaItens";
            this.listaItens.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listaItens.Size = new System.Drawing.Size(295, 199);
            this.listaItens.TabIndex = 2;
            this.listaItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listaItens_KeyDown);
            // 
            // lbRemove
            // 
            this.lbRemove.AutoSize = true;
            this.lbRemove.Location = new System.Drawing.Point(26, 278);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(298, 13);
            this.lbRemove.TabIndex = 3;
            this.lbRemove.Text = "Para remover, seleione um ou mais itens e pressione DELETE";
            // 
            // FormListBoxV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 311);
            this.Controls.Add(this.lbRemove);
            this.Controls.Add(this.listaItens);
            this.Controls.Add(this.txtNovoItem);
            this.Controls.Add(this.lbEnter);
            this.Name = "FormListBoxV2";
            this.Text = "FormListBoxV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnter;
        private System.Windows.Forms.TextBox txtNovoItem;
        private System.Windows.Forms.ListBox listaItens;
        private System.Windows.Forms.Label lbRemove;
    }
}