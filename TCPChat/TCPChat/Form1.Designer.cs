namespace SLLChat
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
            this.Cilent_Create_Button = new System.Windows.Forms.Button();
            this.Server_Create_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cilent_Create_Button
            // 
            this.Cilent_Create_Button.Location = new System.Drawing.Point(12, 12);
            this.Cilent_Create_Button.Name = "Cilent_Create_Button";
            this.Cilent_Create_Button.Size = new System.Drawing.Size(214, 45);
            this.Cilent_Create_Button.TabIndex = 0;
            this.Cilent_Create_Button.Text = "Tạo Cilent mới";
            this.Cilent_Create_Button.UseVisualStyleBackColor = true;
            this.Cilent_Create_Button.Click += new System.EventHandler(this.Cilent_Create_Button_Click);
            // 
            // Server_Create_Button
            // 
            this.Server_Create_Button.Location = new System.Drawing.Point(232, 12);
            this.Server_Create_Button.Name = "Server_Create_Button";
            this.Server_Create_Button.Size = new System.Drawing.Size(220, 45);
            this.Server_Create_Button.TabIndex = 1;
            this.Server_Create_Button.Text = "Tạo Server mới";
            this.Server_Create_Button.UseVisualStyleBackColor = true;
            this.Server_Create_Button.Click += new System.EventHandler(this.Server_Create_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 69);
            this.Controls.Add(this.Server_Create_Button);
            this.Controls.Add(this.Cilent_Create_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cilent_Create_Button;
        private System.Windows.Forms.Button Server_Create_Button;
    }
}

