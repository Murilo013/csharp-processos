namespace teste
{
    partial class FormObter
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
            button1 = new Button();
            button2 = new Button();
            DataGridViewPessoas = new DataGridView();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPessoas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 130);
            button1.Name = "button1";
            button1.Size = new Size(105, 53);
            button1.TabIndex = 0;
            button1.Text = "OBTER TODOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(165, 130);
            button2.Name = "button2";
            button2.Size = new Size(105, 53);
            button2.TabIndex = 1;
            button2.Text = "OBTER POR ID";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DataGridViewPessoas
            // 
            DataGridViewPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPessoas.Location = new Point(323, 12);
            DataGridViewPessoas.Name = "DataGridViewPessoas";
            DataGridViewPessoas.Size = new Size(1111, 276);
            DataGridViewPessoas.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 101);
            txtId.Name = "txtId";
            txtId.Size = new Size(105, 23);
            txtId.TabIndex = 3;
            // 
            // FormObter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 307);
            Controls.Add(txtId);
            Controls.Add(DataGridViewPessoas);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormObter";
            Text = "FormObter";
            ((System.ComponentModel.ISupportInitialize)DataGridViewPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView DataGridViewPessoas;
        private TextBox txtId;
    }
}