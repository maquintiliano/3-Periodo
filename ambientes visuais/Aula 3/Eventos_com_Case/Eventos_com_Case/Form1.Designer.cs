namespace Eventos_com_Case
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
            this.btC = new System.Windows.Forms.Button();
            this.btJava = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(13, 206);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(75, 23);
            this.btC.TabIndex = 0;
            this.btC.Text = "C#";
            this.btC.UseVisualStyleBackColor = true;
            // 
            // btJava
            // 
            this.btJava.Location = new System.Drawing.Point(105, 206);
            this.btJava.Name = "btJava";
            this.btJava.Size = new System.Drawing.Size(75, 23);
            this.btJava.TabIndex = 1;
            this.btJava.Text = "Java";
            this.btJava.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(197, 206);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btJava);
            this.Controls.Add(this.btC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btJava;
        private System.Windows.Forms.Button btSair;
    }
}

