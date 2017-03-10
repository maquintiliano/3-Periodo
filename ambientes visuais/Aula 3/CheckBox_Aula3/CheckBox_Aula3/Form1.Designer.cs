namespace CheckBox_Aula3
{
    partial class Form1
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
            this.lbMudandoTexto = new System.Windows.Forms.Label();
            this.CheckNegao = new System.Windows.Forms.CheckBox();
            this.CheckIta = new System.Windows.Forms.CheckBox();
            this.checkSub = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMudandoTexto
            // 
            this.lbMudandoTexto.AutoSize = true;
            this.lbMudandoTexto.Location = new System.Drawing.Point(75, 90);
            this.lbMudandoTexto.Name = "lbMudandoTexto";
            this.lbMudandoTexto.Size = new System.Drawing.Size(104, 13);
            this.lbMudandoTexto.TabIndex = 0;
            this.lbMudandoTexto.Text = "Click ali e mude aqui";
            // 
            // CheckNegao
            // 
            this.CheckNegao.AutoSize = true;
            this.CheckNegao.Location = new System.Drawing.Point(41, 183);
            this.CheckNegao.Name = "CheckNegao";
            this.CheckNegao.Size = new System.Drawing.Size(58, 17);
            this.CheckNegao.TabIndex = 1;
            this.CheckNegao.Text = "Negão";
            this.CheckNegao.UseVisualStyleBackColor = true;
            this.CheckNegao.CheckedChanged += new System.EventHandler(this.CheckNegao_CheckedChanged);
            // 
            // CheckIta
            // 
            this.CheckIta.AutoSize = true;
            this.CheckIta.Location = new System.Drawing.Point(105, 183);
            this.CheckIta.Name = "CheckIta";
            this.CheckIta.Size = new System.Drawing.Size(54, 17);
            this.CheckIta.TabIndex = 2;
            this.CheckIta.Text = "Ítalico";
            this.CheckIta.UseVisualStyleBackColor = true;
            this.CheckIta.CheckedChanged += new System.EventHandler(this.CheckIta_CheckedChanged);
            // 
            // checkSub
            // 
            this.checkSub.AutoSize = true;
            this.checkSub.Location = new System.Drawing.Point(165, 183);
            this.checkSub.Name = "checkSub";
            this.checkSub.Size = new System.Drawing.Size(79, 17);
            this.checkSub.TabIndex = 3;
            this.checkSub.Text = "Sublinhado";
            this.checkSub.UseVisualStyleBackColor = true;
            this.checkSub.CheckedChanged += new System.EventHandler(this.checkSub_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkSub);
            this.Controls.Add(this.CheckIta);
            this.Controls.Add(this.CheckNegao);
            this.Controls.Add(this.lbMudandoTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMudandoTexto;
        private System.Windows.Forms.CheckBox CheckNegao;
        private System.Windows.Forms.CheckBox CheckIta;
        private System.Windows.Forms.CheckBox checkSub;
        private System.Windows.Forms.Button button1;
    }
}

