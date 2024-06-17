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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnCadastrarConsumidor = new Button();
            btnCadastrarConta = new Button();
            btnConsultarConsumo = new Button();
            btnConsultarValorTotal = new Button();
            btnConsultarValorSemImposto = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarConsumidor
            // 
            btnCadastrarConsumidor.Location = new Point(266, 202);
            btnCadastrarConsumidor.Name = "btnCadastrarConsumidor";
            btnCadastrarConsumidor.Size = new Size(216, 23);
            btnCadastrarConsumidor.TabIndex = 0;
            btnCadastrarConsumidor.Text = "Cadastrar Consumidor";
            btnCadastrarConsumidor.UseVisualStyleBackColor = true;
            btnCadastrarConsumidor.Click += btnCadastrarConsumidor_Click;
            // 
            // btnCadastrarConta
            // 
            btnCadastrarConta.Location = new Point(93, 269);
            btnCadastrarConta.Name = "btnCadastrarConta";
            btnCadastrarConta.Size = new Size(216, 23);
            btnCadastrarConta.TabIndex = 1;
            btnCadastrarConta.Text = "Cadastrar Conta";
            btnCadastrarConta.UseVisualStyleBackColor = true;
            btnCadastrarConta.Click += btnCadastrarConta_Click;
            // 
            // btnConsultarConsumo
            // 
            btnConsultarConsumo.Location = new Point(93, 326);
            btnConsultarConsumo.Name = "btnConsultarConsumo";
            btnConsultarConsumo.Size = new Size(216, 23);
            btnConsultarConsumo.TabIndex = 2;
            btnConsultarConsumo.Text = "Consultar Consumo";
            btnConsultarConsumo.UseVisualStyleBackColor = true;
            btnConsultarConsumo.Click += btnConsultarConsumo_Click;
            // 
            // btnConsultarValorTotal
            // 
            btnConsultarValorTotal.Location = new Point(495, 269);
            btnConsultarValorTotal.Name = "btnConsultarValorTotal";
            btnConsultarValorTotal.Size = new Size(216, 23);
            btnConsultarValorTotal.TabIndex = 3;
            btnConsultarValorTotal.Text = "Consultar Valor Total";
            btnConsultarValorTotal.UseVisualStyleBackColor = true;
            btnConsultarValorTotal.Click += btnConsultarValorTotal_Click;
            // 
            // btnConsultarValorSemImposto
            // 
            btnConsultarValorSemImposto.Location = new Point(495, 326);
            btnConsultarValorSemImposto.Name = "btnConsultarValorSemImposto";
            btnConsultarValorSemImposto.Size = new Size(216, 23);
            btnConsultarValorSemImposto.TabIndex = 4;
            btnConsultarValorSemImposto.Text = "Consultar Valor sem Imposto";
            btnConsultarValorSemImposto.UseVisualStyleBackColor = true;
            btnConsultarValorSemImposto.Click += btnConsultarValorSemImposto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 111);
            label1.Name = "label1";
            label1.Size = new Size(360, 15);
            label1.TabIndex = 5;
            label1.Text = "Seja bem-vindo(a) ao Super Shock, seu sistema de controle elétrico";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(570, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnConsultarValorSemImposto);
            Controls.Add(btnConsultarValorTotal);
            Controls.Add(btnConsultarConsumo);
            Controls.Add(btnCadastrarConta);
            Controls.Add(btnCadastrarConsumidor);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarConsumidor;
        private Button btnCadastrarConta;
        private Button btnConsultarConsumo;
        private Button btnConsultarValorTotal;
        private Button btnConsultarValorSemImposto;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
