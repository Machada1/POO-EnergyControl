namespace SuperShock
{
    partial class FrmCadastrarConta
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
            btnCadastrarConta = new Button();
            txtLeituraAnterior = new TextBox();
            lblLeituraAnterior = new Label();
            txtLeitura = new TextBox();
            lblLeituraAtual = new Label();
            txtTipoConta = new TextBox();
            lblTipoConta = new Label();
            txtCPFCNPJ = new TextBox();
            lblCPFCNPJ = new Label();
            SuspendLayout();
            // 
            // btnCadastrarConta
            // 
            btnCadastrarConta.Location = new Point(344, 338);
            btnCadastrarConta.Name = "btnCadastrarConta";
            btnCadastrarConta.Size = new Size(75, 23);
            btnCadastrarConta.TabIndex = 13;
            btnCadastrarConta.Text = "Cadastrar";
            btnCadastrarConta.UseVisualStyleBackColor = true;
            btnCadastrarConta.Click += btnCadastrarConta_Click;
            // 
            // txtLeituraAnterior
            // 
            txtLeituraAnterior.Location = new Point(157, 247);
            txtLeituraAnterior.Name = "txtLeituraAnterior";
            txtLeituraAnterior.Size = new Size(100, 23);
            txtLeituraAnterior.TabIndex = 12;
            // 
            // lblLeituraAnterior
            // 
            lblLeituraAnterior.AutoSize = true;
            lblLeituraAnterior.Location = new Point(157, 229);
            lblLeituraAnterior.Name = "lblLeituraAnterior";
            lblLeituraAnterior.Size = new Size(135, 15);
            lblLeituraAnterior.TabIndex = 11;
            lblLeituraAnterior.Text = "Leitura do mês anterior: ";
            // 
            // txtLeitura
            // 
            txtLeitura.Location = new Point(157, 158);
            txtLeitura.Name = "txtLeitura";
            txtLeitura.Size = new Size(100, 23);
            txtLeitura.TabIndex = 10;
            // 
            // lblLeituraAtual
            // 
            lblLeituraAtual.AutoSize = true;
            lblLeituraAtual.Location = new Point(157, 140);
            lblLeituraAtual.Name = "lblLeituraAtual";
            lblLeituraAtual.Size = new Size(117, 15);
            lblLeituraAtual.TabIndex = 9;
            lblLeituraAtual.Text = "Leitura do mês atual:";
            // 
            // txtTipoConta
            // 
            txtTipoConta.Location = new Point(157, 86);
            txtTipoConta.Name = "txtTipoConta";
            txtTipoConta.Size = new Size(100, 23);
            txtTipoConta.TabIndex = 8;
            // 
            // lblTipoConta
            // 
            lblTipoConta.AutoSize = true;
            lblTipoConta.Location = new Point(157, 68);
            lblTipoConta.Name = "lblTipoConta";
            lblTipoConta.Size = new Size(209, 15);
            lblTipoConta.TabIndex = 7;
            lblTipoConta.Text = "Tipo de conta (residencial/comercial): ";
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(452, 112);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(100, 23);
            txtCPFCNPJ.TabIndex = 15;
            //txtCPFCNPJ.TextChanged += txtCPFCNPJ_TextChanged;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Location = new Point(452, 94);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(147, 15);
            lblCPFCNPJ.TabIndex = 14;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor:";
            // 
            // FrmCadastrarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCPFCNPJ);
            Controls.Add(lblCPFCNPJ);
            Controls.Add(btnCadastrarConta);
            Controls.Add(txtLeituraAnterior);
            Controls.Add(lblLeituraAnterior);
            Controls.Add(txtLeitura);
            Controls.Add(lblLeituraAtual);
            Controls.Add(txtTipoConta);
            Controls.Add(lblTipoConta);
            Name = "FrmCadastrarConta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Conta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarConta;
        private TextBox txtLeituraAnterior;
        private Label lblLeituraAnterior;
        private TextBox txtLeitura;
        private Label lblLeituraAtual;
        private TextBox txtTipoConta;
        private Label lblTipoConta;
        private TextBox txtCPFCNPJ;
        private Label lblCPFCNPJ;
    }
}