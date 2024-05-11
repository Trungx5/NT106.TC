namespace Lab03_Bai03
{
    partial class Form1
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
            this.TCPServerOpen_Button = new System.Windows.Forms.Button();
            this.TCPCilentOpen_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TCPServerOpen_Button
            // 
            this.TCPServerOpen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCPServerOpen_Button.Location = new System.Drawing.Point(12, 12);
            this.TCPServerOpen_Button.Name = "TCPServerOpen_Button";
            this.TCPServerOpen_Button.Size = new System.Drawing.Size(309, 37);
            this.TCPServerOpen_Button.TabIndex = 0;
            this.TCPServerOpen_Button.Text = "Open TCP Server";
            this.TCPServerOpen_Button.UseVisualStyleBackColor = true;
            this.TCPServerOpen_Button.Click += new System.EventHandler(this.TCPServerOpen_Button_Click);
            // 
            // TCPCilentOpen_Button
            // 
            this.TCPCilentOpen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCPCilentOpen_Button.Location = new System.Drawing.Point(12, 55);
            this.TCPCilentOpen_Button.Name = "TCPCilentOpen_Button";
            this.TCPCilentOpen_Button.Size = new System.Drawing.Size(309, 45);
            this.TCPCilentOpen_Button.TabIndex = 1;
            this.TCPCilentOpen_Button.Text = "Open new TCP Cilent";
            this.TCPCilentOpen_Button.UseVisualStyleBackColor = true;
            this.TCPCilentOpen_Button.Click += new System.EventHandler(this.TCPCilentOpen_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 112);
            this.Controls.Add(this.TCPCilentOpen_Button);
            this.Controls.Add(this.TCPServerOpen_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TCPServerOpen_Button;
        private System.Windows.Forms.Button TCPCilentOpen_Button;
    }
}

