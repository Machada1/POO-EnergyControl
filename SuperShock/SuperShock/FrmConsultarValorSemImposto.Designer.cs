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
            btnSemImposto = new Button();
            txtSemImposto = new TextBox();
            txtCPFCNPJ = new TextBox();
            lblCPFCNPJ = new Label();
            SuspendLayout();
            // 
            // btnSemImposto
            // 
            btnSemImposto.Location = new Point(359, 302);
            btnSemImposto.Name = "btnSemImposto";
            btnSemImposto.Size = new Size(75, 23);
            btnSemImposto.TabIndex = 25;
            btnSemImposto.Text = "Consultar ";
            btnSemImposto.UseVisualStyleBackColor = true;
            btnSemImposto.Click += btnSemImposto_Click;
            // 
            // txtSemImposto
            // 
            txtSemImposto.Location = new Point(272, 238);
            txtSemImposto.Name = "txtSemImposto";
            txtSemImposto.Size = new Size(256, 23);
            txtSemImposto.TabIndex = 24;
            txtSemImposto.Visible = false;
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(344, 144);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(100, 23);
            txtCPFCNPJ.TabIndex = 23;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Location = new Point(324, 126);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(147, 15);
            lblCPFCNPJ.TabIndex = 22;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor:";
            // 
            // FrmConsultarValorSemImposto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSemImposto);
            Controls.Add(txtSemImposto);
            Controls.Add(txtCPFCNPJ);
            Controls.Add(lblCPFCNPJ);
            Name = "FrmConsultarValorSemImposto";
            ShowIcon = false;
            Text = "Consultar Valor sem Imposto";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSemImposto;
        private TextBox txtSemImposto;
        private TextBox txtCPFCNPJ;
        private Label lblCPFCNPJ;
    }
}