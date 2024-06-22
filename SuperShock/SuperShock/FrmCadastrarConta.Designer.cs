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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarConta));
            btnCadastrarConta = new Button();
            txtLeituraAnterior = new TextBox();
            lblLeituraAnterior = new Label();
            txtLeitura = new TextBox();
            lblLeituraAtual = new Label();
            txtTipoConta = new TextBox();
            lblTipoConta = new Label();
            txtCPFCNPJ = new TextBox();
            lblCPFCNPJ = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarConta
            // 
            btnCadastrarConta.BackColor = Color.DarkOrange;
            btnCadastrarConta.Cursor = Cursors.Hand;
            btnCadastrarConta.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnCadastrarConta.ForeColor = Color.Black;
            btnCadastrarConta.Location = new Point(269, 367);
            btnCadastrarConta.Margin = new Padding(0);
            btnCadastrarConta.Name = "btnCadastrarConta";
            btnCadastrarConta.Size = new Size(116, 50);
            btnCadastrarConta.TabIndex = 13;
            btnCadastrarConta.Text = "Cadastrar";
            btnCadastrarConta.UseVisualStyleBackColor = false;
            btnCadastrarConta.Click += btnCadastrarConta_Click;
            // 
            // txtLeituraAnterior
            // 
            txtLeituraAnterior.Location = new Point(157, 247);
            txtLeituraAnterior.Name = "txtLeituraAnterior";
            txtLeituraAnterior.Size = new Size(200, 23);
            txtLeituraAnterior.TabIndex = 12;
            // 
            // lblLeituraAnterior
            // 
            lblLeituraAnterior.AutoSize = true;
            lblLeituraAnterior.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblLeituraAnterior.ForeColor = Color.DarkOrange;
            lblLeituraAnterior.Location = new Point(157, 229);
            lblLeituraAnterior.Name = "lblLeituraAnterior";
            lblLeituraAnterior.Size = new Size(160, 17);
            lblLeituraAnterior.TabIndex = 11;
            lblLeituraAnterior.Text = "Leitura do mês anterior";
            // 
            // txtLeitura
            // 
            txtLeitura.Location = new Point(157, 158);
            txtLeitura.Name = "txtLeitura";
            txtLeitura.Size = new Size(200, 23);
            txtLeitura.TabIndex = 10;
            // 
            // lblLeituraAtual
            // 
            lblLeituraAtual.AutoSize = true;
            lblLeituraAtual.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblLeituraAtual.ForeColor = Color.DarkOrange;
            lblLeituraAtual.Location = new Point(157, 140);
            lblLeituraAtual.Name = "lblLeituraAtual";
            lblLeituraAtual.Size = new Size(142, 17);
            lblLeituraAtual.TabIndex = 9;
            lblLeituraAtual.Text = "Leitura do mês atual";
            // 
            // txtTipoConta
            // 
            txtTipoConta.Location = new Point(157, 86);
            txtTipoConta.Name = "txtTipoConta";
            txtTipoConta.Size = new Size(200, 23);
            txtTipoConta.TabIndex = 8;
            // 
            // lblTipoConta
            // 
            lblTipoConta.AutoSize = true;
            lblTipoConta.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblTipoConta.ForeColor = Color.DarkOrange;
            lblTipoConta.Location = new Point(157, 68);
            lblTipoConta.Name = "lblTipoConta";
            lblTipoConta.Size = new Size(252, 17);
            lblTipoConta.TabIndex = 7;
            lblTipoConta.Text = "Tipo de conta (residencial/comercial)";
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(157, 311);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(200, 23);
            txtCPFCNPJ.TabIndex = 15;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblCPFCNPJ.ForeColor = Color.DarkOrange;
            lblCPFCNPJ.Location = new Point(157, 293);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(174, 17);
            lblCPFCNPJ.TabIndex = 14;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(531, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FrmCadastrarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}