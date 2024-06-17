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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarConsumidor
            // 
            btnCadastrarConsumidor.BackColor = Color.Transparent;
            btnCadastrarConsumidor.BackgroundImageLayout = ImageLayout.None;
            btnCadastrarConsumidor.Cursor = Cursors.Hand;
            btnCadastrarConsumidor.FlatAppearance.BorderColor = Color.Orange;
            btnCadastrarConsumidor.FlatAppearance.BorderSize = 2;
            btnCadastrarConsumidor.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCadastrarConsumidor.FlatStyle = FlatStyle.Flat;
            btnCadastrarConsumidor.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarConsumidor.ForeColor = Color.Orange;
            btnCadastrarConsumidor.Location = new Point(416, 149);
            btnCadastrarConsumidor.Name = "btnCadastrarConsumidor";
            btnCadastrarConsumidor.Size = new Size(216, 30);
            btnCadastrarConsumidor.TabIndex = 0;
            btnCadastrarConsumidor.Text = "Cadastrar Consumidor";
            btnCadastrarConsumidor.UseVisualStyleBackColor = false;
            btnCadastrarConsumidor.Click += btnCadastrarConsumidor_Click;
            // 
            // btnCadastrarConta
            // 
            btnCadastrarConta.BackColor = Color.Transparent;
            btnCadastrarConta.BackgroundImageLayout = ImageLayout.None;
            btnCadastrarConta.Cursor = Cursors.Hand;
            btnCadastrarConta.FlatAppearance.BorderColor = Color.Orange;
            btnCadastrarConta.FlatAppearance.BorderSize = 2;
            btnCadastrarConta.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCadastrarConta.FlatStyle = FlatStyle.Flat;
            btnCadastrarConta.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            btnCadastrarConta.ForeColor = Color.Orange;
            btnCadastrarConta.Location = new Point(416, 185);
            btnCadastrarConta.Name = "btnCadastrarConta";
            btnCadastrarConta.Size = new Size(216, 30);
            btnCadastrarConta.TabIndex = 1;
            btnCadastrarConta.Text = "Cadastrar Conta";
            btnCadastrarConta.UseVisualStyleBackColor = false;
            btnCadastrarConta.Click += btnCadastrarConta_Click;
            // 
            // btnConsultarConsumo
            // 
            btnConsultarConsumo.BackColor = Color.Transparent;
            btnConsultarConsumo.Cursor = Cursors.Hand;
            btnConsultarConsumo.FlatAppearance.BorderColor = Color.Orange;
            btnConsultarConsumo.FlatAppearance.BorderSize = 2;
            btnConsultarConsumo.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConsultarConsumo.FlatStyle = FlatStyle.Flat;
            btnConsultarConsumo.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            btnConsultarConsumo.ForeColor = Color.Orange;
            btnConsultarConsumo.Location = new Point(416, 221);
            btnConsultarConsumo.Name = "btnConsultarConsumo";
            btnConsultarConsumo.Size = new Size(216, 30);
            btnConsultarConsumo.TabIndex = 2;
            btnConsultarConsumo.Text = "Consultar Consumo";
            btnConsultarConsumo.UseVisualStyleBackColor = false;
            btnConsultarConsumo.Click += btnConsultarConsumo_Click;
            // 
            // btnConsultarValorTotal
            // 
            btnConsultarValorTotal.Cursor = Cursors.Hand;
            btnConsultarValorTotal.FlatAppearance.BorderColor = Color.Orange;
            btnConsultarValorTotal.FlatAppearance.BorderSize = 2;
            btnConsultarValorTotal.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConsultarValorTotal.FlatStyle = FlatStyle.Flat;
            btnConsultarValorTotal.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            btnConsultarValorTotal.ForeColor = Color.Orange;
            btnConsultarValorTotal.Location = new Point(416, 257);
            btnConsultarValorTotal.Name = "btnConsultarValorTotal";
            btnConsultarValorTotal.Size = new Size(216, 30);
            btnConsultarValorTotal.TabIndex = 3;
            btnConsultarValorTotal.Text = "Consultar Valor Total";
            btnConsultarValorTotal.UseVisualStyleBackColor = true;
            btnConsultarValorTotal.Click += btnConsultarValorTotal_Click;
            // 
            // btnConsultarValorSemImposto
            // 
            btnConsultarValorSemImposto.Cursor = Cursors.Hand;
            btnConsultarValorSemImposto.FlatAppearance.BorderColor = Color.Orange;
            btnConsultarValorSemImposto.FlatAppearance.BorderSize = 2;
            btnConsultarValorSemImposto.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnConsultarValorSemImposto.FlatStyle = FlatStyle.Flat;
            btnConsultarValorSemImposto.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold);
            btnConsultarValorSemImposto.ForeColor = Color.Orange;
            btnConsultarValorSemImposto.Location = new Point(416, 293);
            btnConsultarValorSemImposto.Name = "btnConsultarValorSemImposto";
            btnConsultarValorSemImposto.Size = new Size(216, 30);
            btnConsultarValorSemImposto.TabIndex = 4;
            btnConsultarValorSemImposto.Text = "Consultar Valor sem Imposto";
            btnConsultarValorSemImposto.UseVisualStyleBackColor = true;
            btnConsultarValorSemImposto.Click += btnConsultarValorSemImposto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(495, 78);
            label2.Name = "label2";
            label2.Size = new Size(178, 19);
            label2.TabIndex = 7;
            label2.Text = "seu sistema de controle elétrico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(173, 32);
            label3.Name = "label3";
            label3.Size = new Size(476, 35);
            label3.TabIndex = 8;
            label3.Text = "Seja bem-vindo(a) ao Super Shock!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(481, 111);
            label1.Name = "label1";
            label1.Size = new Size(86, 35);
            label1.TabIndex = 9;
            label1.Text = "Menu";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
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
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}
