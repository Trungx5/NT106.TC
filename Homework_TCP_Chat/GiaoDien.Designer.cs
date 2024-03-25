namespace Homework_TCP_Chat
{
    partial class GiaoDien
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
            this.Server_Open = new System.Windows.Forms.Button();
            this.Cilent_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server_Open
            // 
            this.Server_Open.Location = new System.Drawing.Point(47, 28);
            this.Server_Open.Name = "Server_Open";
            this.Server_Open.Size = new System.Drawing.Size(113, 23);
            this.Server_Open.TabIndex = 0;
            this.Server_Open.Text = "Mở hộp Server";
            this.Server_Open.UseVisualStyleBackColor = true;
            this.Server_Open.Click += new System.EventHandler(this.Server_Open_Click);
            // 
            // Cilent_Open
            // 
            this.Cilent_Open.Location = new System.Drawing.Point(212, 28);
            this.Cilent_Open.Name = "Cilent_Open";
            this.Cilent_Open.Size = new System.Drawing.Size(113, 23);
            this.Cilent_Open.TabIndex = 1;
            this.Cilent_Open.Text = "Mở hộp Cilent";
            this.Cilent_Open.UseVisualStyleBackColor = true;
            this.Cilent_Open.Click += new System.EventHandler(this.Cilent_Open_Click);
            // 
            // GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 93);
            this.Controls.Add(this.Cilent_Open);
            this.Controls.Add(this.Server_Open);
            this.Name = "GiaoDien";
            this.Text = "GiaoDien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Server_Open;
        private System.Windows.Forms.Button Cilent_Open;
    }
}