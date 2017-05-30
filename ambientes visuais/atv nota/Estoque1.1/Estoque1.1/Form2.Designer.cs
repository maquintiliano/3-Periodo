namespace Estoque1._1
{
    partial class Form2
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
            this.btnconsultarf = new System.Windows.Forms.Button();
            this.btncadp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconsultarf
            // 
            this.btnconsultarf.Location = new System.Drawing.Point(79, 91);
            this.btnconsultarf.Name = "btnconsultarf";
            this.btnconsultarf.Size = new System.Drawing.Size(126, 23);
            this.btnconsultarf.TabIndex = 5;
            this.btnconsultarf.Text = "Fornecedor";
            this.btnconsultarf.UseVisualStyleBackColor = true;
            this.btnconsultarf.Click += new System.EventHandler(this.btnconsultarf_Click);
            // 
            // btncadp
            // 
            this.btncadp.Location = new System.Drawing.Point(79, 146);
            this.btncadp.Name = "btncadp";
            this.btncadp.Size = new System.Drawing.Size(126, 23);
            this.btncadp.TabIndex = 4;
            this.btncadp.Text = "Produto";
            this.btncadp.UseVisualStyleBackColor = true;
            this.btncadp.Click += new System.EventHandler(this.btncadp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnconsultarf);
            this.Controls.Add(this.btncadp);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cervejaria Marry\'s";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconsultarf;
        private System.Windows.Forms.Button btncadp;
    }
}