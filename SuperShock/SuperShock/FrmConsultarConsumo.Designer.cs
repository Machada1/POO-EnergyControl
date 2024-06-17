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
            txtCPFCNPJConsumo = new TextBox();
            lblCPFCNPJ = new Label();
            txtConsumo = new TextBox();
            btnConsultarConsumo = new Button();
            SuspendLayout();
            // 
            // txtCPFCNPJConsumo
            // 
            txtCPFCNPJConsumo.Location = new Point(303, 152);
            txtCPFCNPJConsumo.Name = "txtCPFCNPJConsumo";
            txtCPFCNPJConsumo.Size = new Size(100, 23);
            txtCPFCNPJConsumo.TabIndex = 17;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Location = new Point(277, 115);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(147, 15);
            lblCPFCNPJ.TabIndex = 16;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor:";
            // 
            // txtConsumo
            // 
            txtConsumo.Location = new Point(231, 271);
            txtConsumo.Name = "txtConsumo";
            txtConsumo.Size = new Size(256, 23);
            txtConsumo.TabIndex = 18;
            txtConsumo.Visible = false;
            // 
            // btnConsultarConsumo
            // 
            btnConsultarConsumo.Location = new Point(318, 335);
            btnConsultarConsumo.Name = "btnConsultarConsumo";
            btnConsultarConsumo.Size = new Size(75, 23);
            btnConsultarConsumo.TabIndex = 19;
            btnConsultarConsumo.Text = "Consultar ";
            btnConsultarConsumo.UseVisualStyleBackColor = true;
            btnConsultarConsumo.Click += btnConsultarConsumo_Click;
            // 
            // FrmConsultarConsumo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarConsumo);
            Controls.Add(txtConsumo);
            Controls.Add(txtCPFCNPJConsumo);
            Controls.Add(lblCPFCNPJ);
            Name = "FrmConsultarConsumo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Consumo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPFCNPJConsumo;
        private Label lblCPFCNPJ;
        private TextBox txtConsumo;
        private Button btnConsultarConsumo;
    }
}