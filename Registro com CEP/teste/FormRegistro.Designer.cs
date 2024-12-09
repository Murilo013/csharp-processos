namespace teste
{
    partial class FormRegistro
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
            txtNome = new TextBox();
            txtTelefone = new MaskedTextBox();
            txtEmail = new TextBox();
            txtCEP = new TextBox();
            txtEstado = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtRua = new TextBox();
            txtComplemento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(92, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(187, 29);
            txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(92, 72);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(187, 29);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(92, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 29);
            txtEmail.TabIndex = 2;
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCEP.Location = new Point(92, 164);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(112, 29);
            txtCEP.TabIndex = 3;
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstado.Location = new Point(92, 213);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(148, 29);
            txtEstado.TabIndex = 4;
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(92, 259);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(148, 29);
            txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(313, 213);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(148, 29);
            txtBairro.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(585, 221);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(126, 29);
            txtNumero.TabIndex = 7;
            // 
            // txtRua
            // 
            txtRua.Enabled = false;
            txtRua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRua.Location = new Point(313, 259);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(148, 29);
            txtRua.TabIndex = 8;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComplemento.Location = new Point(585, 262);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(126, 29);
            txtComplemento.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 75);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 11;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 121);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 167);
            label4.Name = "label4";
            label4.Size = new Size(37, 21);
            label4.TabIndex = 13;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 216);
            label5.Name = "label5";
            label5.Size = new Size(56, 21);
            label5.TabIndex = 14;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 262);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 15;
            label6.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(255, 216);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 16;
            label7.Text = "Bairro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(266, 262);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 17;
            label8.Text = "Rua";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(511, 224);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 18;
            label9.Text = "Número";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(470, 265);
            label10.Name = "label10";
            label10.Size = new Size(109, 21);
            label10.TabIndex = 19;
            label10.Text = "Complemento";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(181, 329);
            button1.Name = "button1";
            button1.Size = new Size(98, 42);
            button1.TabIndex = 20;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(313, 329);
            button2.Name = "button2";
            button2.Size = new Size(98, 42);
            button2.TabIndex = 21;
            button2.Text = "Apagar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(210, 163);
            button3.Name = "button3";
            button3.Size = new Size(69, 30);
            button3.TabIndex = 22;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 392);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtComplemento);
            Controls.Add(txtRua);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtCidade);
            Controls.Add(txtEstado);
            Controls.Add(txtCEP);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Name = "FormRegistro";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private MaskedTextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtCEP;
        private TextBox txtEstado;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtRua;
        private TextBox txtComplemento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}