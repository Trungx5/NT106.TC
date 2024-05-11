namespace Lab03_Bai03
{
    partial class TCPServer
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
            this.Listen_Button = new System.Windows.Forms.Button();
            this.MessageServer_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Listen_Button
            // 
            this.Listen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listen_Button.Location = new System.Drawing.Point(469, 12);
            this.Listen_Button.Name = "Listen_Button";
            this.Listen_Button.Size = new System.Drawing.Size(143, 46);
            this.Listen_Button.TabIndex = 2;
            this.Listen_Button.Text = "Listen";
            this.Listen_Button.UseVisualStyleBackColor = true;
            this.Listen_Button.Click += new System.EventHandler(this.Listen_Button_Click_1);
            // 
            // MessageServer_TextBox
            // 
            this.MessageServer_TextBox.Location = new System.Drawing.Point(12, 66);
            this.MessageServer_TextBox.Name = "MessageServer_TextBox";
            this.MessageServer_TextBox.Size = new System.Drawing.Size(600, 270);
            this.MessageServer_TextBox.TabIndex = 3;
            this.MessageServer_TextBox.Text = "";
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 348);
            this.Controls.Add(this.MessageServer_TextBox);
            this.Controls.Add(this.Listen_Button);
            this.Name = "TCPServer";
            this.Text = "TCPServer";
            this.Load += new System.EventHandler(this.TCPServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Listen_Button;
        private System.Windows.Forms.RichTextBox MessageServer_TextBox;
    }
}