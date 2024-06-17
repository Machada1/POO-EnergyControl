namespace SuperShock
{
    partial class FrmConsultarConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarConsumo));
            txtCPFCNPJConsumo = new TextBox();
            lblCPFCNPJ = new Label();
            txtConsumo = new TextBox();
            btnConsultarConsumo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCPFCNPJConsumo
            // 
            txtCPFCNPJConsumo.Location = new Point(224, 157);
            txtCPFCNPJConsumo.Name = "txtCPFCNPJConsumo";
            txtCPFCNPJConsumo.Size = new Size(200, 23);
            txtCPFCNPJConsumo.TabIndex = 17;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblCPFCNPJ.ForeColor = Color.DarkOrange;
            lblCPFCNPJ.Location = new Point(224, 137);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(174, 17);
            lblCPFCNPJ.TabIndex = 16;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor";
            lblCPFCNPJ.Click += lblCPFCNPJ_Click;
            // 
            // txtConsumo
            // 
            txtConsumo.Location = new Point(183, 251);
            txtConsumo.Multiline = true;
            txtConsumo.Name = "txtConsumo";
            txtConsumo.Size = new Size(256, 23);
            txtConsumo.TabIndex = 18;
            txtConsumo.Visible = false;
            // 
            // btnConsultarConsumo
            // 
            btnConsultarConsumo.BackColor = Color.DarkOrange;
            btnConsultarConsumo.Cursor = Cursors.Hand;
            btnConsultarConsumo.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnConsultarConsumo.Location = new Point(255, 333);
            btnConsultarConsumo.Name = "btnConsultarConsumo";
            btnConsultarConsumo.Size = new Size(116, 50);
            btnConsultarConsumo.TabIndex = 19;
            btnConsultarConsumo.Text = "Consultar";
            btnConsultarConsumo.UseVisualStyleBackColor = false;
            btnConsultarConsumo.Click += btnConsultarConsumo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(532, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnConsultarConsumo);
            Controls.Add(txtConsumo);
            Controls.Add(txtCPFCNPJConsumo);
            Controls.Add(lblCPFCNPJ);
            Name = "FrmConsultarConsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Consumo";
            Load += FrmConsultarConsumo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPFCNPJConsumo;
        private Label lblCPFCNPJ;
        private TextBox txtConsumo;
        private Button btnConsultarConsumo;
        private PictureBox pictureBox1;
    }
}