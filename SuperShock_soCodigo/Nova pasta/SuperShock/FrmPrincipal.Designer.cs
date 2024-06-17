namespace SuperShock
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrarConsumidor = new Button();
            btnCadastrarConta = new Button();
            btnConsultarConsumo = new Button();
            btnConsultarValorTotal = new Button();
            btnConsultarValorSemImposto = new Button();
            SuspendLayout();
            // 
            // btnCadastrarConsumidor
            // 
            btnCadastrarConsumidor.Location = new Point(82, 112);
            btnCadastrarConsumidor.Name = "btnCadastrarConsumidor";
            btnCadastrarConsumidor.Size = new Size(216, 23);
            btnCadastrarConsumidor.TabIndex = 0;
            btnCadastrarConsumidor.Text = "Cadastrar Consumidor";
            btnCadastrarConsumidor.UseVisualStyleBackColor = true;
            btnCadastrarConsumidor.Click += btnCadastrarConsumidor_Click;
            // 
            // btnCadastrarConta
            // 
            btnCadastrarConta.Location = new Point(82, 178);
            btnCadastrarConta.Name = "btnCadastrarConta";
            btnCadastrarConta.Size = new Size(216, 23);
            btnCadastrarConta.TabIndex = 1;
            btnCadastrarConta.Text = "Cadastrar Conta";
            btnCadastrarConta.UseVisualStyleBackColor = true;
            btnCadastrarConta.Click += btnCadastrarConta_Click;
            // 
            // btnConsultarConsumo
            // 
            btnConsultarConsumo.Location = new Point(82, 246);
            btnConsultarConsumo.Name = "btnConsultarConsumo";
            btnConsultarConsumo.Size = new Size(216, 23);
            btnConsultarConsumo.TabIndex = 2;
            btnConsultarConsumo.Text = "Consultar Consumo";
            btnConsultarConsumo.UseVisualStyleBackColor = true;
            btnConsultarConsumo.Click += btnConsultarConsumo_Click;
            // 
            // btnConsultarValorTotal
            // 
            btnConsultarValorTotal.Location = new Point(82, 312);
            btnConsultarValorTotal.Name = "btnConsultarValorTotal";
            btnConsultarValorTotal.Size = new Size(216, 23);
            btnConsultarValorTotal.TabIndex = 3;
            btnConsultarValorTotal.Text = "Consultar Valor Total";
            btnConsultarValorTotal.UseVisualStyleBackColor = true;
            btnConsultarValorTotal.Click += btnConsultarValorTotal_Click;
            // 
            // btnConsultarValorSemImposto
            // 
            btnConsultarValorSemImposto.Location = new Point(386, 112);
            btnConsultarValorSemImposto.Name = "btnConsultarValorSemImposto";
            btnConsultarValorSemImposto.Size = new Size(216, 23);
            btnConsultarValorSemImposto.TabIndex = 4;
            btnConsultarValorSemImposto.Text = "Consultar Valor sem Imposto";
            btnConsultarValorSemImposto.UseVisualStyleBackColor = true;
            btnConsultarValorSemImposto.Click += btnConsultarValorSemImposto_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarValorSemImposto);
            Controls.Add(btnConsultarValorTotal);
            Controls.Add(btnConsultarConsumo);
            Controls.Add(btnCadastrarConta);
            Controls.Add(btnCadastrarConsumidor);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarConsumidor;
        private Button btnCadastrarConta;
        private Button btnConsultarConsumo;
        private Button btnConsultarValorTotal;
        private Button btnConsultarValorSemImposto;
    }
}
