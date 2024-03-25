namespace Homework_TCP_Chat
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
            this.Start = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.txtBox_Status = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(407, 31);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(76, 36);
            this.Start.TabIndex = 0;
            this.Start.Text = "Bắt Đầu";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(489, 31);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(76, 36);
            this.End.TabIndex = 1;
            this.End.Text = "Kết thúc";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(60, 38);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(62, 20);
            this.Port.TabIndex = 4;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(198, 40);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(187, 20);
            this.Host.TabIndex = 5;
            // 
            // txtBox_Status
            // 
            this.txtBox_Status.Location = new System.Drawing.Point(16, 82);
            this.txtBox_Status.Name = "txtBox_Status";
            this.txtBox_Status.Size = new System.Drawing.Size(549, 270);
            this.txtBox_Status.TabIndex = 6;
            this.txtBox_Status.Text = "";
            this.txtBox_Status.TextChanged += new System.EventHandler(this.txtBox_Status_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.txtBox_Status);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.RichTextBox txtBox_Status;
    }
}