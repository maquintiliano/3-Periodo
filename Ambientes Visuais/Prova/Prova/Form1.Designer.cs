namespace Prova
{
    partial class Locadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.descicao = new System.Windows.Forms.Label();
            this.gbVeiculo = new System.Windows.Forms.GroupBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDataInicio = new System.Windows.Forms.TextBox();
            this.lbDataFim = new System.Windows.Forms.Label();
            this.tbDataFim = new System.Windows.Forms.TextBox();
            this.cbTipoCli = new System.Windows.Forms.ComboBox();
            this.lbTipoCli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btRemoever = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.painelPrincipal.SuspendLayout();
            this.gbVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.descicao);
            this.painelPrincipal.Location = new System.Drawing.Point(34, 13);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(813, 48);
            this.painelPrincipal.TabIndex = 0;
            // 
            // descicao
            // 
            this.descicao.AutoSize = true;
            this.descicao.Location = new System.Drawing.Point(378, 14);
            this.descicao.Name = "descicao";
            this.descicao.Size = new System.Drawing.Size(55, 13);
            this.descicao.TabIndex = 0;
            this.descicao.Text = "Descrição";
            // 
            // gbVeiculo
            // 
            this.gbVeiculo.Controls.Add(this.btRemoever);
            this.gbVeiculo.Controls.Add(this.cbTipoCli);
            this.gbVeiculo.Controls.Add(this.btIncluir);
            this.gbVeiculo.Controls.Add(this.lbTipoCli);
            this.gbVeiculo.Controls.Add(this.tbDataFim);
            this.gbVeiculo.Controls.Add(this.lbDataFim);
            this.gbVeiculo.Controls.Add(this.tbDataInicio);
            this.gbVeiculo.Controls.Add(this.label1);
            this.gbVeiculo.Controls.Add(this.lbCod);
            this.gbVeiculo.Controls.Add(this.tbCodigo);
            this.gbVeiculo.Location = new System.Drawing.Point(34, 79);
            this.gbVeiculo.Name = "gbVeiculo";
            this.gbVeiculo.Size = new System.Drawing.Size(274, 179);
            this.gbVeiculo.TabIndex = 1;
            this.gbVeiculo.TabStop = false;
            this.gbVeiculo.Text = "Veiculo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(168, 23);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 2;
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(77, 29);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(43, 13);
            this.lbCod.TabIndex = 3;
            this.lbCod.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data de Inicio:";
            // 
            // tbDataInicio
            // 
            this.tbDataInicio.Location = new System.Drawing.Point(168, 53);
            this.tbDataInicio.Name = "tbDataInicio";
            this.tbDataInicio.Size = new System.Drawing.Size(100, 20);
            this.tbDataInicio.TabIndex = 5;
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Location = new System.Drawing.Point(56, 84);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(64, 13);
            this.lbDataFim.TabIndex = 6;
            this.lbDataFim.Text = "Data de fim:";
            // 
            // tbDataFim
            // 
            this.tbDataFim.Location = new System.Drawing.Point(168, 81);
            this.tbDataFim.Name = "tbDataFim";
            this.tbDataFim.Size = new System.Drawing.Size(100, 20);
            this.tbDataFim.TabIndex = 7;
            // 
            // cbTipoCli
            // 
            this.cbTipoCli.FormattingEnabled = true;
            this.cbTipoCli.Items.AddRange(new object[] {
            "Coorporativo",
            "Particular",
            ""});
            this.cbTipoCli.Location = new System.Drawing.Point(168, 107);
            this.cbTipoCli.Name = "cbTipoCli";
            this.cbTipoCli.Size = new System.Drawing.Size(100, 21);
            this.cbTipoCli.TabIndex = 8;
            // 
            // lbTipoCli
            // 
            this.lbTipoCli.AutoSize = true;
            this.lbTipoCli.Location = new System.Drawing.Point(39, 108);
            this.lbTipoCli.Name = "lbTipoCli";
            this.lbTipoCli.Size = new System.Drawing.Size(81, 13);
            this.lbTipoCli.TabIndex = 9;
            this.lbTipoCli.Text = "Tipo de Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Cartão a Vista",
            "Cartão a Prazo"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(165, 16);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(100, 21);
            this.cbFormaPagamento.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCod,
            this.clMarca,
            this.clModelo,
            this.clValorAluguel});
            this.dataGridView1.Location = new System.Drawing.Point(349, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 172);
            this.dataGridView1.TabIndex = 2;
            // 
            // clCod
            // 
            this.clCod.HeaderText = "Código";
            this.clCod.Name = "clCod";
            // 
            // clMarca
            // 
            this.clMarca.HeaderText = "Marca";
            this.clMarca.Name = "clMarca";
            // 
            // clModelo
            // 
            this.clModelo.HeaderText = "Modelo";
            this.clModelo.Name = "clModelo";
            // 
            // clValorAluguel
            // 
            this.clValorAluguel.HeaderText = "Valor do Aluguel";
            this.clValorAluguel.Name = "clValorAluguel";
            // 
            // gbValores
            // 
            this.gbValores.Controls.Add(this.btFinalizar);
            this.gbValores.Controls.Add(this.tbTotal);
            this.gbValores.Controls.Add(this.lbTotal);
            this.gbValores.Controls.Add(this.cbFormaPagamento);
            this.gbValores.Controls.Add(this.label2);
            this.gbValores.Location = new System.Drawing.Point(34, 264);
            this.gbValores.Name = "gbValores";
            this.gbValores.Size = new System.Drawing.Size(274, 100);
            this.gbValores.TabIndex = 3;
            this.gbValores.TabStop = false;
            this.gbValores.Text = "Pagamento";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(83, 39);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(165, 43);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 4;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(112, 150);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 4;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            // 
            // btRemoever
            // 
            this.btRemoever.Location = new System.Drawing.Point(193, 150);
            this.btRemoever.Name = "btRemoever";
            this.btRemoever.Size = new System.Drawing.Size(75, 23);
            this.btRemoever.TabIndex = 5;
            this.btRemoever.Text = "Remover";
            this.btRemoever.UseVisualStyleBackColor = true;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(190, 71);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 4;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            // 
            // Locadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 427);
            this.Controls.Add(this.gbValores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbVeiculo);
            this.Controls.Add(this.painelPrincipal);
            this.Name = "Locadora";
            this.Text = "Locadora de Veiculos";
            this.painelPrincipal.ResumeLayout(false);
            this.painelPrincipal.PerformLayout();
            this.gbVeiculo.ResumeLayout(false);
            this.gbVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbValores.ResumeLayout(false);
            this.gbValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Label descicao;
        private System.Windows.Forms.GroupBox gbVeiculo;
        private System.Windows.Forms.Label lbTipoCli;
        private System.Windows.Forms.ComboBox cbTipoCli;
        private System.Windows.Forms.TextBox tbDataFim;
        private System.Windows.Forms.Label lbDataFim;
        private System.Windows.Forms.TextBox tbDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorAluguel;
        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btRemoever;
        private System.Windows.Forms.Button btFinalizar;
    }
}

