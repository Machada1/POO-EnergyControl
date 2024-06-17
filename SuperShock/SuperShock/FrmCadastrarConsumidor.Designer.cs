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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarConsumidor));
            lblNomeConsumidor = new Label();
            txtNomeConsumidor = new TextBox();
            lblCPFCNPJ = new Label();
            txtCPFCNPJ = new TextBox();
            lblTipo = new Label();
            txtTipoConsumidor = new TextBox();
            btnCadastrarConsumidor = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNomeConsumidor
            // 
            lblNomeConsumidor.AutoSize = true;
            lblNomeConsumidor.BackColor = Color.Transparent;
            lblNomeConsumidor.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblNomeConsumidor.ForeColor = Color.DarkOrange;
            lblNomeConsumidor.Location = new Point(100, 107);
            lblNomeConsumidor.Name = "lblNomeConsumidor";
            lblNomeConsumidor.Size = new Size(155, 17);
            lblNomeConsumidor.TabIndex = 0;
            lblNomeConsumidor.Text = "Nome do Consumidor: ";
            // 
            // txtNomeConsumidor
            // 
            txtNomeConsumidor.BackColor = SystemColors.Window;
            txtNomeConsumidor.ForeColor = Color.Black;
            txtNomeConsumidor.Location = new Point(100, 127);
            txtNomeConsumidor.Name = "txtNomeConsumidor";
            txtNomeConsumidor.Size = new Size(200, 23);
            txtNomeConsumidor.TabIndex = 1;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblCPFCNPJ.ForeColor = Color.DarkOrange;
            lblCPFCNPJ.Location = new Point(100, 185);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(143, 17);
            lblCPFCNPJ.TabIndex = 2;
            lblCPFCNPJ.Text = "CPF do Consumidor: ";
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.BackColor = SystemColors.Window;
            txtCPFCNPJ.Location = new Point(100, 205);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(200, 23);
            txtCPFCNPJ.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblTipo.ForeColor = Color.DarkOrange;
            lblTipo.Location = new Point(100, 263);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(392, 17);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de Consumidor (1. Pessoa Física, 2. Pessoa Jurídica) : ";
            lblTipo.Click += lblTipo_Click;
            // 
            // txtTipoConsumidor
            // 
            txtTipoConsumidor.BackColor = SystemColors.Window;
            txtTipoConsumidor.Location = new Point(100, 292);
            txtTipoConsumidor.Name = "txtTipoConsumidor";
            txtTipoConsumidor.Size = new Size(200, 23);
            txtTipoConsumidor.TabIndex = 5;
            // 
            // btnCadastrarConsumidor
            // 
            btnCadastrarConsumidor.BackColor = Color.DarkOrange;
            btnCadastrarConsumidor.Cursor = Cursors.Hand;
            btnCadastrarConsumidor.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarConsumidor.ForeColor = Color.Black;
            btnCadastrarConsumidor.Location = new Point(288, 350);
            btnCadastrarConsumidor.Margin = new Padding(0);
            btnCadastrarConsumidor.Name = "btnCadastrarConsumidor";
            btnCadastrarConsumidor.Size = new Size(116, 50);
            btnCadastrarConsumidor.TabIndex = 6;
            btnCadastrarConsumidor.Text = "Cadastrar";
            btnCadastrarConsumidor.UseVisualStyleBackColor = false;
            btnCadastrarConsumidor.Click += btnCadastrarConsumidor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(533, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmCadastrarConsumidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}