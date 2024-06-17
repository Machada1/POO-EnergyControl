namespace SuperShock
{
    partial class FrmConsultarValorSemImposto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarValorSemImposto));
            btnSemImposto = new Button();
            txtSemImposto = new TextBox();
            txtCPFCNPJ = new TextBox();
            lblCPFCNPJ = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSemImposto
            // 
            btnSemImposto.BackColor = Color.DarkOrange;
            btnSemImposto.Cursor = Cursors.Hand;
            btnSemImposto.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnSemImposto.ForeColor = Color.Black;
            btnSemImposto.Location = new Point(215, 293);
            btnSemImposto.Name = "btnSemImposto";
            btnSemImposto.Size = new Size(116, 50);
            btnSemImposto.TabIndex = 25;
            btnSemImposto.Text = "Consultar";
            btnSemImposto.UseVisualStyleBackColor = false;
            btnSemImposto.Click += btnSemImposto_Click;
            // 
            // txtSemImposto
            // 
            txtSemImposto.Location = new Point(140, 222);
            txtSemImposto.Name = "txtSemImposto";
            txtSemImposto.Size = new Size(256, 23);
            txtSemImposto.TabIndex = 24;
            txtSemImposto.Visible = false;
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(178, 130);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(200, 23);
            txtCPFCNPJ.TabIndex = 23;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.BackColor = Color.Transparent;
            lblCPFCNPJ.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblCPFCNPJ.ForeColor = Color.DarkOrange;
            lblCPFCNPJ.Location = new Point(178, 110);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(174, 17);
            lblCPFCNPJ.TabIndex = 22;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(529, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarValorSemImposto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSemImposto);
            Controls.Add(txtSemImposto);
            Controls.Add(txtCPFCNPJ);
            Controls.Add(lblCPFCNPJ);
            Name = "FrmConsultarValorSemImposto";
            ShowIcon = false;
            Text = "Consultar Valor sem Imposto";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSemImposto;
        private TextBox txtSemImposto;
        private TextBox txtCPFCNPJ;
        private Label lblCPFCNPJ;
        private PictureBox pictureBox1;
    }
}