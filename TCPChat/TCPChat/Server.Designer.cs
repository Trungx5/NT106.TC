namespace SLLChat
{
    partial class Server
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
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.MessageContent_RTextBox = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerConnect_Button = new System.Windows.Forms.Button();
            this.Server_Disconnect_Button = new System.Windows.Forms.Button();
            this.PictureBox_Message = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Message)).BeginInit();
            this.SuspendLayout();
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Location = new System.Drawing.Point(75, 32);
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(216, 20);
            this.IP_TextBox.TabIndex = 0;
            this.IP_TextBox.Text = "127.0.0.1";
            // 
            // MessageContent_RTextBox
            // 
            this.MessageContent_RTextBox.Location = new System.Drawing.Point(32, 67);
            this.MessageContent_RTextBox.Name = "MessageContent_RTextBox";
            this.MessageContent_RTextBox.ReadOnly = true;
            this.MessageContent_RTextBox.Size = new System.Drawing.Size(756, 323);
            this.MessageContent_RTextBox.TabIndex = 1;
            this.MessageContent_RTextBox.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(771, 67);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 323);
            this.vScrollBar1.TabIndex = 2;
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(366, 34);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(101, 20);
            this.Port_TextBox.TabIndex = 3;
            this.Port_TextBox.Text = "5000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // ServerConnect_Button
            // 
            this.ServerConnect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerConnect_Button.Location = new System.Drawing.Point(496, 29);
            this.ServerConnect_Button.Name = "ServerConnect_Button";
            this.ServerConnect_Button.Size = new System.Drawing.Size(108, 31);
            this.ServerConnect_Button.TabIndex = 6;
            this.ServerConnect_Button.Text = "Kết nối";
            this.ServerConnect_Button.UseVisualStyleBackColor = true;
            this.ServerConnect_Button.Click += new System.EventHandler(this.ServerConnect_Button_Click);
            // 
            // Server_Disconnect_Button
            // 
            this.Server_Disconnect_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_Disconnect_Button.Location = new System.Drawing.Point(627, 30);
            this.Server_Disconnect_Button.Name = "Server_Disconnect_Button";
            this.Server_Disconnect_Button.Size = new System.Drawing.Size(100, 30);
            this.Server_Disconnect_Button.TabIndex = 7;
            this.Server_Disconnect_Button.Text = "Dừng";
            this.Server_Disconnect_Button.UseVisualStyleBackColor = true;
            // 
            // PictureBox_Message
            // 
            this.PictureBox_Message.Location = new System.Drawing.Point(32, 396);
            this.PictureBox_Message.Name = "PictureBox_Message";
            this.PictureBox_Message.Size = new System.Drawing.Size(695, 96);
            this.PictureBox_Message.TabIndex = 22;
            this.PictureBox_Message.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.PictureBox_Message);
            this.Controls.Add(this.Server_Disconnect_Button);
            this.Controls.Add(this.ServerConnect_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.MessageContent_RTextBox);
            this.Controls.Add(this.IP_TextBox);
            this.Name = "Server";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_TextBox;
        private System.Windows.Forms.RichTextBox MessageContent_RTextBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ServerConnect_Button;
        private System.Windows.Forms.Button Server_Disconnect_Button;
        private System.Windows.Forms.PictureBox PictureBox_Message;
    }
}