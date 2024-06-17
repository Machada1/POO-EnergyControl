namespace SuperShock
{
    partial class FrmConsultarValorTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarValorTotal));
            txtCPFCNPJ = new TextBox();
            lblCPFCNPJ = new Label();
            btnValorTotal = new Button();
            txtValorTotal = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(210, 142);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(200, 23);
            txtCPFCNPJ.TabIndex = 19;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.BackColor = Color.Transparent;
            lblCPFCNPJ.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            lblCPFCNPJ.ForeColor = Color.DarkOrange;
            lblCPFCNPJ.Location = new Point(210, 122);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(174, 17);
            lblCPFCNPJ.TabIndex = 18;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor";
            // 
            // btnValorTotal
            // 
            btnValorTotal.BackColor = Color.DarkOrange;
            btnValorTotal.Cursor = Cursors.Hand;
            btnValorTotal.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold);
            btnValorTotal.ForeColor = Color.Black;
            btnValorTotal.Location = new Point(258, 298);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(116, 50);
            btnValorTotal.TabIndex = 21;
            btnValorTotal.Text = "Consultar";
            btnValorTotal.UseVisualStyleBackColor = false;
            btnValorTotal.Click += btnValorTotal_Click;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(171, 234);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(256, 23);
            txtValorTotal.TabIndex = 20;
            txtValorTotal.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(532, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // FrmConsultarValorTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnValorTotal);
            Controls.Add(txtValorTotal);
            Controls.Add(txtCPFCNPJ);
            Controls.Add(lblCPFCNPJ);
            Name = "FrmConsultarValorTotal";
            Text = "Consultar Valor Total";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPFCNPJ;
        private Label lblCPFCNPJ;
        private Button btnValorTotal;
        private TextBox txtValorTotal;
        private PictureBox pictureBox1;
    }
}