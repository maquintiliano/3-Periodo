namespace listBox_Eventos
{
    partial class FormCheckedListBox
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
            this.clbLivros = new System.Windows.Forms.CheckedListBox();
            this.lbSelecao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clbLivros
            // 
            this.clbLivros.FormattingEnabled = true;
            this.clbLivros.Items.AddRange(new object[] {
            "C#",
            "Java",
            "PHP",
            "Phyton",
            "Pascal"});
            this.clbLivros.Location = new System.Drawing.Point(32, 29);
            this.clbLivros.Name = "clbLivros";
            this.clbLivros.Size = new System.Drawing.Size(142, 244);
            this.clbLivros.TabIndex = 0;
            this.clbLivros.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbLivros_ItemCheck);
            // 
            // lbSelecao
            // 
            this.lbSelecao.FormattingEnabled = true;
            this.lbSelecao.Location = new System.Drawing.Point(202, 29);
            this.lbSelecao.Name = "lbSelecao";
            this.lbSelecao.Size = new System.Drawing.Size(142, 238);
            this.lbSelecao.TabIndex = 1;
            // 
            // FormCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 310);
            this.Controls.Add(this.lbSelecao);
            this.Controls.Add(this.clbLivros);
            this.Name = "FormCheckedListBox";
            this.Text = "FormCheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbLivros;
        private System.Windows.Forms.ListBox lbSelecao;
    }
}