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
            txtCPFCNPJ = new TextBox();
            lblCPFCNPJ = new Label();
            btnValorTotal = new Button();
            txtValorTotal = new TextBox();
            SuspendLayout();
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(314, 146);
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(100, 23);
            txtCPFCNPJ.TabIndex = 19;
            // 
            // lblCPFCNPJ
            // 
            lblCPFCNPJ.AutoSize = true;
            lblCPFCNPJ.Location = new Point(294, 128);
            lblCPFCNPJ.Name = "lblCPFCNPJ";
            lblCPFCNPJ.Size = new Size(147, 15);
            lblCPFCNPJ.TabIndex = 18;
            lblCPFCNPJ.Text = "CPF/CNPJ do consumidor:";
            // 
            // btnValorTotal
            // 
            btnValorTotal.Location = new Point(329, 304);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(75, 23);
            btnValorTotal.TabIndex = 21;
            btnValorTotal.Text = "Consultar ";
            btnValorTotal.UseVisualStyleBackColor = true;
            btnValorTotal.Click += btnValorTotal_Click;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(242, 240);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(256, 23);
            txtValorTotal.TabIndex = 20;
            txtValorTotal.Visible = false;
            // 
            // FrmConsultarValorTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValorTotal);
            Controls.Add(txtValorTotal);
            Controls.Add(txtCPFCNPJ);
            Controls.Add(lblCPFCNPJ);
            Name = "FrmConsultarValorTotal";
            Text = "Consultar Valor Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCPFCNPJ;
        private Label lblCPFCNPJ;
        private Button btnValorTotal;
        private TextBox txtValorTotal;
    }
}