namespace teste
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(85, 144);
            button1.Margin = new Padding(5, 2, 5, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 49);
            button1.TabIndex = 0;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(85, 197);
            button2.Margin = new Padding(5, 2, 5, 2);
            button2.Name = "button2";
            button2.Size = new Size(128, 49);
            button2.TabIndex = 1;
            button2.Text = "OBTER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(85, 303);
            button3.Margin = new Padding(5, 2, 5, 2);
            button3.Name = "button3";
            button3.Size = new Size(128, 49);
            button3.TabIndex = 2;
            button3.Text = "REMOVER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(85, 250);
            button4.Margin = new Padding(5, 2, 5, 2);
            button4.Name = "button4";
            button4.Size = new Size(128, 49);
            button4.TabIndex = 3;
            button4.Text = "ATUALIZAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 55);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 51);
            label1.TabIndex = 4;
            label1.Text = "Cadastro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(305, 390);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 2, 5, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}
