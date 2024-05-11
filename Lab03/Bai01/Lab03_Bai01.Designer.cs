namespace Bai01
{
    partial class Lab03_Bai01
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
            this.Server_button = new System.Windows.Forms.Button();
            this.Cilent_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Server_button
            // 
            this.Server_button.Location = new System.Drawing.Point(12, 30);
            this.Server_button.Name = "Server_button";
            this.Server_button.Size = new System.Drawing.Size(128, 51);
            this.Server_button.TabIndex = 0;
            this.Server_button.Text = "Server";
            this.Server_button.UseVisualStyleBackColor = true;
            this.Server_button.Click += new System.EventHandler(this.Server_button_Click);
            // 
            // Cilent_Button
            // 
            this.Cilent_Button.Location = new System.Drawing.Point(189, 30);
            this.Cilent_Button.Name = "Cilent_Button";
            this.Cilent_Button.Size = new System.Drawing.Size(128, 51);
            this.Cilent_Button.TabIndex = 1;
            this.Cilent_Button.Text = "Cilent";
            this.Cilent_Button.UseVisualStyleBackColor = true;
            this.Cilent_Button.Click += new System.EventHandler(this.Cilent_Button_Click);
            // 
            // Lab03_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 110);
            this.Controls.Add(this.Cilent_Button);
            this.Controls.Add(this.Server_button);
            this.Name = "Lab03_Bai01";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Server_button;
        private System.Windows.Forms.Button Cilent_Button;
    }
}

