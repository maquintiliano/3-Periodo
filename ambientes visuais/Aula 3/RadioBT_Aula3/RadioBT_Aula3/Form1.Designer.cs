namespace RadioBT_Aula3
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
            this.lbMensagem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtRepetirCancelar = new System.Windows.Forms.RadioButton();
            this.rbtSimNao = new System.Windows.Forms.RadioButton();
            this.rbtSimNaoCancelar = new System.Windows.Forms.RadioButton();
            this.rbtAnularRepetirCancelar = new System.Windows.Forms.RadioButton();
            this.rbtOkCancelar = new System.Windows.Forms.RadioButton();
            this.rbtOk = new System.Windows.Forms.RadioButton();
            this.rbtAnularRepetirIgnorar = new System.Windows.Forms.GroupBox();
            this.rbtPergunta = new System.Windows.Forms.RadioButton();
            this.rbtInformacao = new System.Windows.Forms.RadioButton();
            this.rbtExclamacao = new System.Windows.Forms.RadioButton();
            this.rbtErro = new System.Windows.Forms.RadioButton();
            this.btExibir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.rbtAnularRepetirIgnorar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Location = new System.Drawing.Point(25, 37);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(238, 13);
            this.lbMensagem.TabIndex = 0;
            this.lbMensagem.Text = "Escolha o tipo de MessageBox que deseja exibir!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRepetirCancelar);
            this.groupBox1.Controls.Add(this.rbtSimNao);
            this.groupBox1.Controls.Add(this.rbtSimNaoCancelar);
            this.groupBox1.Controls.Add(this.rbtAnularRepetirCancelar);
            this.groupBox1.Controls.Add(this.rbtOkCancelar);
            this.groupBox1.Controls.Add(this.rbtOk);
            this.groupBox1.Location = new System.Drawing.Point(2, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Botão";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtRepetirCancelar
            // 
            this.rbtRepetirCancelar.AutoSize = true;
            this.rbtRepetirCancelar.Location = new System.Drawing.Point(6, 135);
            this.rbtRepetirCancelar.Name = "rbtRepetirCancelar";
            this.rbtRepetirCancelar.Size = new System.Drawing.Size(112, 17);
            this.rbtRepetirCancelar.TabIndex = 5;
            this.rbtRepetirCancelar.TabStop = true;
            this.rbtRepetirCancelar.Text = "Repeitr / Cancelar";
            this.rbtRepetirCancelar.UseVisualStyleBackColor = true;
            this.rbtRepetirCancelar.CheckedChanged += new System.EventHandler(this.tipoBotao_CheckedChanged);
            // 
            // rbtSimNao
            // 
            this.rbtSimNao.AutoSize = true;
            this.rbtSimNao.Location = new System.Drawing.Point(6, 112);
            this.rbtSimNao.Name = "rbtSimNao";
            this.rbtSimNao.Size = new System.Drawing.Size(76, 17);
            this.rbtSimNao.TabIndex = 4;
            this.rbtSimNao.TabStop = true;
            this.rbtSimNao.Text = "Sim / Não ";
            this.rbtSimNao.UseVisualStyleBackColor = true;
            this.rbtSimNao.CheckedChanged += new System.EventHandler(this.tipoBotao_CheckedChanged);
            // 
            // rbtSimNaoCancelar
            // 
            this.rbtSimNaoCancelar.AutoSize = true;
            this.rbtSimNaoCancelar.Location = new System.Drawing.Point(6, 89);
            this.rbtSimNaoCancelar.Name = "rbtSimNaoCancelar";
            this.rbtSimNaoCancelar.Size = new System.Drawing.Size(126, 17);
            this.rbtSimNaoCancelar.TabIndex = 3;
            this.rbtSimNaoCancelar.TabStop = true;
            this.rbtSimNaoCancelar.Text = "Sim / Não / Cancelar";
            this.rbtSimNaoCancelar.UseVisualStyleBackColor = true;
            this.rbtSimNaoCancelar.CheckedChanged += new System.EventHandler(this.tipoBotao_CheckedChanged);
            // 
            // rbtAnularRepetirCancelar
            // 
            this.rbtAnularRepetirCancelar.AutoSize = true;
            this.rbtAnularRepetirCancelar.Location = new System.Drawing.Point(7, 66);
            this.rbtAnularRepetirCancelar.Name = "rbtAnularRepetirCancelar";
            this.rbtAnularRepetirCancelar.Size = new System.Drawing.Size(141, 17);
            this.rbtAnularRepetirCancelar.TabIndex = 2;
            this.rbtAnularRepetirCancelar.TabStop = true;
            this.rbtAnularRepetirCancelar.Text = "Anula / Repetir / Ignorar";
            this.rbtAnularRepetirCancelar.UseVisualStyleBackColor = true;
            this.rbtAnularRepetirCancelar.CheckedChanged += new System.EventHandler(this.tipoBotao_CheckedChanged);
            // 
            // rbtOkCancelar
            // 
            this.rbtOkCancelar.AutoSize = true;
            this.rbtOkCancelar.Location = new System.Drawing.Point(6, 43);
            this.rbtOkCancelar.Name = "rbtOkCancelar";
            this.rbtOkCancelar.Size = new System.Drawing.Size(86, 17);
            this.rbtOkCancelar.TabIndex = 1;
            this.rbtOkCancelar.TabStop = true;
            this.rbtOkCancelar.Text = "Ok/Cancelar";
            this.rbtOkCancelar.UseVisualStyleBackColor = true;
            this.rbtOkCancelar.CheckedChanged += new System.EventHandler(this.tipoBotao_CheckedChanged);
            // 
            // rbtOk
            // 
            this.rbtOk.AutoSize = true;
            this.rbtOk.Location = new System.Drawing.Point(7, 20);
            this.rbtOk.Name = "rbtOk";
            this.rbtOk.Size = new System.Drawing.Size(43, 17);
            this.rbtOk.TabIndex = 0;
            this.rbtOk.TabStop = true;
            this.rbtOk.Text = "OK!";
            this.rbtOk.UseVisualStyleBackColor = true;
            this.rbtOk.CheckedChanged += new System.EventHandler(this.tipoBotao_CheckedChanged);
            // 
            // rbtAnularRepetirIgnorar
            // 
            this.rbtAnularRepetirIgnorar.Controls.Add(this.rbtPergunta);
            this.rbtAnularRepetirIgnorar.Controls.Add(this.rbtInformacao);
            this.rbtAnularRepetirIgnorar.Controls.Add(this.rbtExclamacao);
            this.rbtAnularRepetirIgnorar.Controls.Add(this.rbtErro);
            this.rbtAnularRepetirIgnorar.Location = new System.Drawing.Point(165, 78);
            this.rbtAnularRepetirIgnorar.Name = "rbtAnularRepetirIgnorar";
            this.rbtAnularRepetirIgnorar.Size = new System.Drawing.Size(107, 116);
            this.rbtAnularRepetirIgnorar.TabIndex = 2;
            this.rbtAnularRepetirIgnorar.TabStop = false;
            this.rbtAnularRepetirIgnorar.Text = "Icone";
            // 
            // rbtPergunta
            // 
            this.rbtPergunta.AutoSize = true;
            this.rbtPergunta.Location = new System.Drawing.Point(6, 89);
            this.rbtPergunta.Name = "rbtPergunta";
            this.rbtPergunta.Size = new System.Drawing.Size(68, 17);
            this.rbtPergunta.TabIndex = 7;
            this.rbtPergunta.TabStop = true;
            this.rbtPergunta.Text = "Pergunta";
            this.rbtPergunta.UseVisualStyleBackColor = true;
            this.rbtPergunta.CheckedChanged += new System.EventHandler(this.tipoIcone_ChekedChanged);
            // 
            // rbtInformacao
            // 
            this.rbtInformacao.AutoSize = true;
            this.rbtInformacao.Location = new System.Drawing.Point(6, 66);
            this.rbtInformacao.Name = "rbtInformacao";
            this.rbtInformacao.Size = new System.Drawing.Size(78, 17);
            this.rbtInformacao.TabIndex = 6;
            this.rbtInformacao.TabStop = true;
            this.rbtInformacao.Text = "Informação";
            this.rbtInformacao.UseVisualStyleBackColor = true;
            this.rbtInformacao.CheckedChanged += new System.EventHandler(this.tipoIcone_ChekedChanged);
            // 
            // rbtExclamacao
            // 
            this.rbtExclamacao.AutoSize = true;
            this.rbtExclamacao.Location = new System.Drawing.Point(6, 43);
            this.rbtExclamacao.Name = "rbtExclamacao";
            this.rbtExclamacao.Size = new System.Drawing.Size(83, 17);
            this.rbtExclamacao.TabIndex = 5;
            this.rbtExclamacao.TabStop = true;
            this.rbtExclamacao.Text = "Exclamação";
            this.rbtExclamacao.UseVisualStyleBackColor = true;
            this.rbtExclamacao.CheckedChanged += new System.EventHandler(this.tipoIcone_ChekedChanged);
            // 
            // rbtErro
            // 
            this.rbtErro.AutoSize = true;
            this.rbtErro.Location = new System.Drawing.Point(6, 19);
            this.rbtErro.Name = "rbtErro";
            this.rbtErro.Size = new System.Drawing.Size(44, 17);
            this.rbtErro.TabIndex = 4;
            this.rbtErro.TabStop = true;
            this.rbtErro.Text = "Erro";
            this.rbtErro.UseVisualStyleBackColor = true;
            this.rbtErro.CheckedChanged += new System.EventHandler(this.tipoIcone_ChekedChanged);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(165, 200);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(107, 40);
            this.btExibir.TabIndex = 3;
            this.btExibir.Text = "Exibir";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.rbtAnularRepetirIgnorar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rbtAnularRepetirIgnorar.ResumeLayout(false);
            this.rbtAnularRepetirIgnorar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtRepetirCancelar;
        private System.Windows.Forms.RadioButton rbtSimNao;
        private System.Windows.Forms.RadioButton rbtSimNaoCancelar;
        private System.Windows.Forms.RadioButton rbtAnularRepetirCancelar;
        private System.Windows.Forms.RadioButton rbtOkCancelar;
        private System.Windows.Forms.RadioButton rbtOk;
        private System.Windows.Forms.GroupBox rbtAnularRepetirIgnorar;
        private System.Windows.Forms.RadioButton rbtPergunta;
        private System.Windows.Forms.RadioButton rbtInformacao;
        private System.Windows.Forms.RadioButton rbtExclamacao;
        private System.Windows.Forms.RadioButton rbtErro;
        private System.Windows.Forms.Button btExibir;
    }
}

