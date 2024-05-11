namespace Lab03_GiaoDien
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
            this.Bai01_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bai01_Button
            // 
            this.Bai01_Button.Location = new System.Drawing.Point(12, 12);
            this.Bai01_Button.Name = "Bai01_Button";
            this.Bai01_Button.Size = new System.Drawing.Size(84, 51);
            this.Bai01_Button.TabIndex = 0;
            this.Bai01_Button.Text = "Bai01";
            this.Bai01_Button.UseVisualStyleBackColor = true;
            this.Bai01_Button.Click += new System.EventHandler(this.Bai01_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 69);
            this.Controls.Add(this.Bai01_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bai01_Button;
    }
}

