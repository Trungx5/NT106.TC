namespace Bai01
{
    partial class UDP_Server
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
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Listen_Button = new System.Windows.Forms.Button();
            this.MessageRecieved__TextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(80, 38);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(97, 20);
            this.Port_TextBox.TabIndex = 5;
            this.Port_TextBox.Text = "8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // Listen_Button
            // 
            this.Listen_Button.Location = new System.Drawing.Point(399, 36);
            this.Listen_Button.Name = "Listen_Button";
            this.Listen_Button.Size = new System.Drawing.Size(75, 23);
            this.Listen_Button.TabIndex = 6;
            this.Listen_Button.Text = "Listen";
            this.Listen_Button.UseVisualStyleBackColor = true;
            this.Listen_Button.Click += new System.EventHandler(this.Listen_Button_Click);
            // 
            // MessageRecieved__TextBox
            // 
            this.MessageRecieved__TextBox.Location = new System.Drawing.Point(35, 91);
            this.MessageRecieved__TextBox.Name = "MessageRecieved__TextBox";
            this.MessageRecieved__TextBox.Size = new System.Drawing.Size(433, 194);
            this.MessageRecieved__TextBox.TabIndex = 8;
            this.MessageRecieved__TextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Recieved Message";
            // 
            // UDP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 352);
            this.Controls.Add(this.MessageRecieved__TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Listen_Button);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.label2);
            this.Name = "UDP_Server";
            this.Text = "UDP_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Listen_Button;
        private System.Windows.Forms.RichTextBox MessageRecieved__TextBox;
        private System.Windows.Forms.Label label3;
    }
}