namespace listBox_Eventos
{
    partial class Principal
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
            this.lbAula = new System.Windows.Forms.Label();
            this.btListBoxV1 = new System.Windows.Forms.Button();
            this.btListBoxV2 = new System.Windows.Forms.Button();
            this.btCheckedList = new System.Windows.Forms.Button();
            this.btComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAula
            // 
            this.lbAula.AutoSize = true;
            this.lbAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAula.Location = new System.Drawing.Point(137, 37);
            this.lbAula.Name = "lbAula";
            this.lbAula.Size = new System.Drawing.Size(344, 38);
            this.lbAula.TabIndex = 0;
            this.lbAula.Text = "Exemplos da Aula 04";
            // 
            // btListBoxV1
            // 
            this.btListBoxV1.Location = new System.Drawing.Point(126, 146);
            this.btListBoxV1.Name = "btListBoxV1";
            this.btListBoxV1.Size = new System.Drawing.Size(75, 23);
            this.btListBoxV1.TabIndex = 1;
            this.btListBoxV1.Text = "ListBox V1";
            this.btListBoxV1.UseVisualStyleBackColor = true;
            this.btListBoxV1.Click += new System.EventHandler(this.btListBoxV1_Click);
            // 
            // btListBoxV2
            // 
            this.btListBoxV2.Location = new System.Drawing.Point(225, 146);
            this.btListBoxV2.Name = "btListBoxV2";
            this.btListBoxV2.Size = new System.Drawing.Size(75, 23);
            this.btListBoxV2.TabIndex = 2;
            this.btListBoxV2.Text = "ListBox V2";
            this.btListBoxV2.UseVisualStyleBackColor = true;
            this.btListBoxV2.Click += new System.EventHandler(this.btListBoxV2_Click);
            // 
            // btCheckedList
            // 
            this.btCheckedList.Location = new System.Drawing.Point(320, 146);
            this.btCheckedList.Name = "btCheckedList";
            this.btCheckedList.Size = new System.Drawing.Size(75, 23);
            this.btCheckedList.TabIndex = 3;
            this.btCheckedList.Text = "CheckedList";
            this.btCheckedList.UseVisualStyleBackColor = true;
            this.btCheckedList.Click += new System.EventHandler(this.btCheckedList_Click);
            // 
            // btComboBox
            // 
            this.btComboBox.Location = new System.Drawing.Point(417, 146);
            this.btComboBox.Name = "btComboBox";
            this.btComboBox.Size = new System.Drawing.Size(75, 23);
            this.btComboBox.TabIndex = 4;
            this.btComboBox.Text = "ComboBox";
            this.btComboBox.UseVisualStyleBackColor = true;
            this.btComboBox.Click += new System.EventHandler(this.btComboBox_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 261);
            this.Controls.Add(this.btComboBox);
            this.Controls.Add(this.btCheckedList);
            this.Controls.Add(this.btListBoxV2);
            this.Controls.Add(this.btListBoxV1);
            this.Controls.Add(this.lbAula);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAula;
        private System.Windows.Forms.Button btListBoxV1;
        private System.Windows.Forms.Button btListBoxV2;
        private System.Windows.Forms.Button btCheckedList;
        private System.Windows.Forms.Button btComboBox;
    }
}