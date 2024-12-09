namespace teste
{
    partial class FormRemover
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
            txtIdDelete = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(55, 153);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 0;
            button1.Text = "Remover";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdDelete
            // 
            txtIdDelete.Location = new Point(55, 96);
            txtIdDelete.Multiline = true;
            txtIdDelete.Name = "txtIdDelete";
            txtIdDelete.Size = new Size(114, 37);
            txtIdDelete.TabIndex = 1;
            // 
            // FormRemover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 257);
            Controls.Add(txtIdDelete);
            Controls.Add(button1);
            Name = "FormRemover";
            Text = "FormRemover";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtIdDelete;
    }
}