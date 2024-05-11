namespace Bai01
{
    partial class UDP_Cilent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPRemote_TextBox = new System.Windows.Forms.TextBox();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Message__TextBox = new System.Windows.Forms.RichTextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remote Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // IPRemote_TextBox
            // 
            this.IPRemote_TextBox.Location = new System.Drawing.Point(35, 49);
            this.IPRemote_TextBox.Name = "IPRemote_TextBox";
            this.IPRemote_TextBox.Size = new System.Drawing.Size(307, 20);
            this.IPRemote_TextBox.TabIndex = 2;
            this.IPRemote_TextBox.Text = "127.0.0.1";
            this.IPRemote_TextBox.TextChanged += new System.EventHandler(this.IPRemote_TextBox_TextChanged);
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(371, 49);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(97, 20);
            this.Port_TextBox.TabIndex = 3;
            this.Port_TextBox.Text = "8080";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message";
            // 
            // Message__TextBox
            // 
            this.Message__TextBox.Location = new System.Drawing.Point(35, 138);
            this.Message__TextBox.Name = "Message__TextBox";
            this.Message__TextBox.Size = new System.Drawing.Size(433, 194);
            this.Message__TextBox.TabIndex = 5;
            this.Message__TextBox.Text = "";
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(35, 338);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 6;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // UDP_Cilent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 392);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Message__TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.IPRemote_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UDP_Cilent";
            this.Text = "UDP_Cilent";
            this.Load += new System.EventHandler(this.UDP_Cilent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPRemote_TextBox;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Message__TextBox;
        private System.Windows.Forms.Button Send_Button;
    }
}