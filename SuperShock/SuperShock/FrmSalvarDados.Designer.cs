namespace SuperShock
{
    partial class FrmSalvarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalvarDados));
            pictureBox1 = new PictureBox();
            btnSalvarDados = new Button();
            txtNomeArquivo = new TextBox();
            lblNomeArquivo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(530, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            //pictureBox1.Click += this.pictureBox1_Click;
            // 
            // btnSalvarDados
            // 
            btnSalvarDados.BackColor = Color.DarkOrange;
            btnSalvarDados.Cursor = Cursors.Hand;
            btnSalvarDados.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnSalvarDados.ForeColor = Color.Black;
            btnSalvarDados.Location = new Point(212, 297);
            btnSalvarDados.Name = "btnSalvarDados";
            btnSalvarDados.Size = new Size(116, 50);
            btnSalvarDados.TabIndex = 30;
            btnSalvarDados.Text = "Salvar";
            btnSalvarDados.UseVisualStyleBackColor = false;
            btnSalvarDados.Click += btnSalvarDados_Click;
            // 
            // txtNomeArquivo
            // 
            txtNomeArquivo.Location = new Point(157, 194);
            txtNomeArquivo.Name = "txtNomeArquivo";
            txtNomeArquivo.Size = new Size(200, 23);
            txtNomeArquivo.TabIndex = 29;
            //txtNomeArquivo.TextChanged += this.txtNomeArquivo_TextChanged;
            // 
            // lblNomeArquivo
            // 
            lblNomeArquivo.AutoSize = true;
            lblNomeArquivo.BackColor = Color.Transparent;
            lblNomeArquivo.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblNomeArquivo.ForeColor = Color.DarkOrange;
            lblNomeArquivo.Location = new Point(157, 174);
            lblNomeArquivo.Name = "lblNomeArquivo";
            lblNomeArquivo.Size = new Size(256, 17);
            lblNomeArquivo.TabIndex = 28;
            lblNomeArquivo.Text = "Nome do arquivo para salvar os dados";
            lblNomeArquivo.Click += lblNomeArquivo_Click;
            // 
            // FrmSalvarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalvarDados);
            Controls.Add(txtNomeArquivo);
            Controls.Add(lblNomeArquivo);
            Name = "FrmSalvarDados";
            Text = "Salvar Dados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Button btnSalvarDados;
        public TextBox txtNomeArquivo;
        private Label lblNomeArquivo;
    }
}