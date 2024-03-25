namespace Homework_TCP_Chat
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
            this.Host = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.Send_Message = new System.Windows.Forms.Button();
            this.Message_Content_Box = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(203, 12);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(187, 20);
            this.Host.TabIndex = 10;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(65, 10);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(62, 20);
            this.Port.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Host:";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(408, 8);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(76, 27);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Kết nối";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(12, 332);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(400, 54);
            this.MessageBox.TabIndex = 11;
            this.MessageBox.Text = "";
            this.MessageBox.TextChanged += new System.EventHandler(this.MessageBox_TextChanged);
            // 
            // Send_Message
            // 
            this.Send_Message.Location = new System.Drawing.Point(418, 348);
            this.Send_Message.Name = "Send_Message";
            this.Send_Message.Size = new System.Drawing.Size(75, 23);
            this.Send_Message.TabIndex = 12;
            this.Send_Message.Text = "Gửi!";
            this.Send_Message.UseVisualStyleBackColor = true;
            this.Send_Message.Click += new System.EventHandler(this.Send_Message_Click);
            // 
            // Message_Content_Box
            // 
            this.Message_Content_Box.Location = new System.Drawing.Point(12, 61);
            this.Message_Content_Box.Name = "Message_Content_Box";
            this.Message_Content_Box.ReadOnly = true;
            this.Message_Content_Box.Size = new System.Drawing.Size(400, 265);
            this.Message_Content_Box.TabIndex = 13;
            this.Message_Content_Box.Text = "";
            this.Message_Content_Box.TextChanged += new System.EventHandler(this.Message_Content_Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên:";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(63, 40);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(187, 20);
            this.UserName.TabIndex = 15;
            // 
            // Cilent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Message_Content_Box);
            this.Controls.Add(this.Send_Message);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Name = "Cilent";
            this.Text = "Cilent";
            this.Load += new System.EventHandler(this.Cilent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.RichTextBox MessageBox;
        private System.Windows.Forms.Button Send_Message;
        private System.Windows.Forms.RichTextBox Message_Content_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
    }
}