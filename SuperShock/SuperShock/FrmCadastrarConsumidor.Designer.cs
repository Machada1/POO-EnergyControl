namespace SuperShock
{
    partial class FrmCadastrarConsumidor
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
            lblNomeConsumidor = new Label();
            txtNomeConsumidor = new TextBox();
            lblCPFCNPJ = new Label();
            txtCPFCNPJ = new TextBox();
            lblTipo = new Label();
            txtTipoConsumidor = new TextBox();
            btnCadastrarConsumidor = new Button();
            SuspendLayout();
            // 
            // lblNomeConsumidor
            // 
            lblNomeConsumidor.AutoSize = true;
            lblNomeConsumidor.Location = new Point(87, 64);
            lblNomeConsumidor.Name = "lblNomeConsumidor";
            lblNomeConsumidor.Size = new Size(132, 15);
            lblNomeConsumidor.TabIndex = 0;
            lblNomeConsumidor.Text = "Nome do Consumidor: ";
            // 
            // txtNomeConsumidor
            // 
            txtNomeConsumidor.Location = new Point(87, 82);
            txtNomeConsumidor.Name = "txtNomeConsumidor";
            txtNomeConsumidor.Size = new Size(100, 23);
            txtNomeConsumidor.TabIndex = 1;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Location = new Point(87, 136);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(120, 15);
            lblCPFCNPJ.TabIndex = 2;
            lblCPFCNPJ.Text = "CPF do Consumidor: ";
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(87, 154);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(100, 23);
            txtCPFCNPJ.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(87, 212);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(312, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de Consumidor (1. Pessoa Física, 2. Pessoa Jurídica) : ";
            // 
            // txtTipoConsumidor
            // 
            txtTipoConsumidor.Location = new Point(87, 242);
            txtTipoConsumidor.Name = "txtTipoConsumidor";
            txtTipoConsumidor.Size = new Size(100, 23);
            txtTipoConsumidor.TabIndex = 5;
            // 
            // btnCadastrarConsumidor
            // 
            btnCadastrarConsumidor.Location = new Point(274, 334);
            btnCadastrarConsumidor.Name = "btnCadastrarConsumidor";
            btnCadastrarConsumidor.Size = new Size(75, 23);
            btnCadastrarConsumidor.TabIndex = 6;
            btnCadastrarConsumidor.Text = "Cadastrar";
            btnCadastrarConsumidor.UseVisualStyleBackColor = true;
            btnCadastrarConsumidor.Click += btnCadastrarConsumidor_Click;
            // 
            // FrmCadastrarConsumidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarConsumidor);
            Controls.Add(txtTipoConsumidor);
            Controls.Add(lblTipo);
            Controls.Add(txtCPFCNPJ);
            Controls.Add(lblCPFCNPJ);
            Controls.Add(txtNomeConsumidor);
            Controls.Add(lblNomeConsumidor);
            Name = "FrmCadastrarConsumidor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Consumidor";
            Load += FrmCadastrarConsumidor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeConsumidor;
        private TextBox txtNomeConsumidor;
        private Label lblCPFCNPJ;
        private TextBox txtCPFCNPJ;
        private Label lblTipo;
        private TextBox txtTipoConsumidor;
        private Button btnCadastrarConsumidor;
    }
}