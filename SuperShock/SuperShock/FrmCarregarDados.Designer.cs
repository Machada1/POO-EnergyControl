namespace SuperShock
{
    partial class FrmCarregarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarregarDados));
            pictureBox1 = new PictureBox();
            btnCarregarDados = new Button();
            txtNomeArquivo = new TextBox();
            lblNomeArquivoCarregar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(530, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // btnCarregarDados
            // 
            btnCarregarDados.BackColor = Color.DarkOrange;
            btnCarregarDados.Cursor = Cursors.Hand;
            btnCarregarDados.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnCarregarDados.ForeColor = Color.Black;
            btnCarregarDados.Location = new Point(212, 295);
            btnCarregarDados.Name = "btnCarregarDados";
            btnCarregarDados.Size = new Size(116, 50);
            btnCarregarDados.TabIndex = 34;
            btnCarregarDados.Text = "Carregar";
            btnCarregarDados.UseVisualStyleBackColor = false;
            btnCarregarDados.Click += btnCarregarDados_Click;
            // 
            // txtNomeArquivo
            // 
            txtNomeArquivo.Location = new Point(157, 192);
            txtNomeArquivo.Name = "txtNomeArquivo";
            txtNomeArquivo.Size = new Size(200, 23);
            txtNomeArquivo.TabIndex = 33;
            // 
            // lblNomeArquivoCarregar
            // 
            lblNomeArquivoCarregar.AutoSize = true;
            lblNomeArquivoCarregar.BackColor = Color.Transparent;
            lblNomeArquivoCarregar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblNomeArquivoCarregar.ForeColor = Color.DarkOrange;
            lblNomeArquivoCarregar.Location = new Point(157, 172);
            lblNomeArquivoCarregar.Name = "lblNomeArquivoCarregar";
            lblNomeArquivoCarregar.Size = new Size(271, 17);
            lblNomeArquivoCarregar.TabIndex = 32;
            lblNomeArquivoCarregar.Text = "Nome do arquivo para carregar os dados";
            // 
            // FrmCarregarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCarregarDados);
            Controls.Add(txtNomeArquivo);
            Controls.Add(lblNomeArquivoCarregar);
            Name = "FrmCarregarDados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carregar Dados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Button btnCarregarDados;
        public TextBox txtNomeArquivo;
        private Label lblNomeArquivoCarregar;
    }
}