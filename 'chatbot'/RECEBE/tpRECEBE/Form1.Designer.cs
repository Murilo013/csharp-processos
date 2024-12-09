namespace tpRECEBE
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
            this.listmsg = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.msg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listmsg
            // 
            this.listmsg.FormattingEnabled = true;
            this.listmsg.ItemHeight = 15;
            this.listmsg.Location = new System.Drawing.Point(21, 12);
            this.listmsg.Name = "listmsg";
            this.listmsg.Size = new System.Drawing.Size(214, 364);
            this.listmsg.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "ABRIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "FECHAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(21, 399);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(167, 23);
            this.msg.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 521);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listmsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listmsg;
        private Button button1;
        private Button button2;
        private TextBox msg;
        private Button button3;
    }
}