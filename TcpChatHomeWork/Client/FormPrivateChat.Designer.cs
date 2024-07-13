namespace Client
{
    partial class FormPrivateChat
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
            label1 = new Label();
            panel1 = new Panel();
            richTextBoxPrivate = new RichTextBox();
            label2 = new Label();
            textBoxMessagePrivate = new TextBox();
            buttonSendPrivate = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(richTextBoxPrivate);
            panel1.Location = new Point(12, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 368);
            panel1.TabIndex = 1;
            // 
            // richTextBoxPrivate
            // 
            richTextBoxPrivate.BorderStyle = BorderStyle.None;
            richTextBoxPrivate.Dock = DockStyle.Fill;
            richTextBoxPrivate.Location = new Point(0, 0);
            richTextBoxPrivate.Name = "richTextBoxPrivate";
            richTextBoxPrivate.ReadOnly = true;
            richTextBoxPrivate.Size = new Size(577, 366);
            richTextBoxPrivate.TabIndex = 0;
            richTextBoxPrivate.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 467);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Message:";
            // 
            // textBoxMessagePrivate
            // 
            textBoxMessagePrivate.Location = new Point(13, 504);
            textBoxMessagePrivate.Name = "textBoxMessagePrivate";
            textBoxMessagePrivate.Size = new Size(436, 31);
            textBoxMessagePrivate.TabIndex = 3;
            // 
            // buttonSendPrivate
            // 
            buttonSendPrivate.Location = new Point(474, 499);
            buttonSendPrivate.Name = "buttonSendPrivate";
            buttonSendPrivate.Size = new Size(116, 41);
            buttonSendPrivate.TabIndex = 4;
            buttonSendPrivate.Text = "Send";
            buttonSendPrivate.UseVisualStyleBackColor = true;
            buttonSendPrivate.Click += buttonSendPrivate_Click;
            // 
            // FormPrivateChat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 557);
            Controls.Add(buttonSendPrivate);
            Controls.Add(textBoxMessagePrivate);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormPrivateChat";
            Text = "FormPrivateChat";
            Load += FormPrivateChat_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RichTextBox richTextBoxPrivate;
        private Label label2;
        private TextBox textBoxMessagePrivate;
        private Button buttonSendPrivate;
    }
}