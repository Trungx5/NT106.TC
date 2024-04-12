namespace SLLChat
{
    partial class Cilent
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
            this.Server_Disconnect_Button_Cilent = new System.Windows.Forms.Button();
            this.ServerConnect_Button_Cilent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_TextBox_Cilent = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.MessageContent_RTextBox_Cilent = new System.Windows.Forms.RichTextBox();
            this.IP_TextBox_Cilent = new System.Windows.Forms.TextBox();
            this.Message_Send_Content_Cilent_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Send_Msg_Cilent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Server_Disconnect_Button_Cilent
            // 
            this.Server_Disconnect_Button_Cilent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_Disconnect_Button_Cilent.Location = new System.Drawing.Point(617, 46);
            this.Server_Disconnect_Button_Cilent.Name = "Server_Disconnect_Button_Cilent";
            this.Server_Disconnect_Button_Cilent.Size = new System.Drawing.Size(100, 30);
            this.Server_Disconnect_Button_Cilent.TabIndex = 15;
            this.Server_Disconnect_Button_Cilent.Text = "Dừng";
            this.Server_Disconnect_Button_Cilent.UseVisualStyleBackColor = true;
            this.Server_Disconnect_Button_Cilent.Click += new System.EventHandler(this.Server_Disconnect_Button_Cilent_Click_1);
            // 
            // ServerConnect_Button_Cilent
            // 
            this.ServerConnect_Button_Cilent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerConnect_Button_Cilent.Location = new System.Drawing.Point(486, 45);
            this.ServerConnect_Button_Cilent.Name = "ServerConnect_Button_Cilent";
            this.ServerConnect_Button_Cilent.Size = new System.Drawing.Size(108, 31);
            this.ServerConnect_Button_Cilent.TabIndex = 14;
            this.ServerConnect_Button_Cilent.Text = "Kết nối";
            this.ServerConnect_Button_Cilent.UseVisualStyleBackColor = true;
            this.ServerConnect_Button_Cilent.Click += new System.EventHandler(this.ServerConnect_Button_Cilent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP";
            // 
            // Port_TextBox_Cilent
            // 
            this.Port_TextBox_Cilent.Location = new System.Drawing.Point(356, 50);
            this.Port_TextBox_Cilent.Name = "Port_TextBox_Cilent";
            this.Port_TextBox_Cilent.Size = new System.Drawing.Size(101, 20);
            this.Port_TextBox_Cilent.TabIndex = 11;
            this.Port_TextBox_Cilent.Text = "5000";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(761, 83);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 211);
            this.vScrollBar1.TabIndex = 10;
            // 
            // MessageContent_RTextBox_Cilent
            // 
            this.MessageContent_RTextBox_Cilent.Location = new System.Drawing.Point(22, 83);
            this.MessageContent_RTextBox_Cilent.Name = "MessageContent_RTextBox_Cilent";
            this.MessageContent_RTextBox_Cilent.ReadOnly = true;
            this.MessageContent_RTextBox_Cilent.Size = new System.Drawing.Size(756, 211);
            this.MessageContent_RTextBox_Cilent.TabIndex = 9;
            this.MessageContent_RTextBox_Cilent.Text = "";
            // 
            // IP_TextBox_Cilent
            // 
            this.IP_TextBox_Cilent.Location = new System.Drawing.Point(65, 48);
            this.IP_TextBox_Cilent.Name = "IP_TextBox_Cilent";
            this.IP_TextBox_Cilent.Size = new System.Drawing.Size(216, 20);
            this.IP_TextBox_Cilent.TabIndex = 8;
            this.IP_TextBox_Cilent.Text = "127.0.0.1";
            // 
            // Message_Send_Content_Cilent_RichTextBox
            // 
            this.Message_Send_Content_Cilent_RichTextBox.Location = new System.Drawing.Point(22, 300);
            this.Message_Send_Content_Cilent_RichTextBox.Name = "Message_Send_Content_Cilent_RichTextBox";
            this.Message_Send_Content_Cilent_RichTextBox.Size = new System.Drawing.Size(572, 128);
            this.Message_Send_Content_Cilent_RichTextBox.TabIndex = 16;
            this.Message_Send_Content_Cilent_RichTextBox.Text = "";
            // 
            // Send_Msg_Cilent
            // 
            this.Send_Msg_Cilent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Msg_Cilent.Location = new System.Drawing.Point(600, 300);
            this.Send_Msg_Cilent.Name = "Send_Msg_Cilent";
            this.Send_Msg_Cilent.Size = new System.Drawing.Size(178, 128);
            this.Send_Msg_Cilent.TabIndex = 17;
            this.Send_Msg_Cilent.Text = "Gửi tin nhắn";
            this.Send_Msg_Cilent.UseVisualStyleBackColor = true;
            this.Send_Msg_Cilent.Click += new System.EventHandler(this.Send_Msg_Cilent_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username";
            // 
            // UserName_Input
            // 
            this.UserName_Input.Location = new System.Drawing.Point(136, 14);
            this.UserName_Input.Name = "UserName_Input";
            this.UserName_Input.Size = new System.Drawing.Size(581, 20);
            this.UserName_Input.TabIndex = 19;
            // 
            // Cilent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserName_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Send_Msg_Cilent);
            this.Controls.Add(this.Message_Send_Content_Cilent_RichTextBox);
            this.Controls.Add(this.Server_Disconnect_Button_Cilent);
            this.Controls.Add(this.ServerConnect_Button_Cilent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port_TextBox_Cilent);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.MessageContent_RTextBox_Cilent);
            this.Controls.Add(this.IP_TextBox_Cilent);
            this.Name = "Cilent";
            this.Text = "Cilent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Server_Disconnect_Button_Cilent;
        private System.Windows.Forms.Button ServerConnect_Button_Cilent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_TextBox_Cilent;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.RichTextBox MessageContent_RTextBox_Cilent;
        private System.Windows.Forms.TextBox IP_TextBox_Cilent;
        private System.Windows.Forms.RichTextBox Message_Send_Content_Cilent_RichTextBox;
        private System.Windows.Forms.Button Send_Msg_Cilent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName_Input;
    }
}