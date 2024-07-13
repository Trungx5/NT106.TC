namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            textBoxYourName = new TextBox();
            buttonConnect = new Button();
            label3 = new Label();
            textBoxMessage = new TextBox();
            buttonSend = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 330);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(573, 328);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 23);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 1;
            label1.Text = "Participates:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(608, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 304);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 376);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 3;
            label2.Text = "Your Name:";
            // 
            // textBoxYourName
            // 
            textBoxYourName.Location = new Point(122, 376);
            textBoxYourName.Name = "textBoxYourName";
            textBoxYourName.Size = new Size(270, 31);
            textBoxYourName.TabIndex = 4;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(417, 376);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(112, 34);
            buttonConnect.TabIndex = 5;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 446);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 6;
            label3.Text = "Message:";
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(13, 492);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(448, 31);
            textBoxMessage.TabIndex = 7;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(482, 489);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(105, 34);
            buttonSend.TabIndex = 8;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 536);
            Controls.Add(buttonSend);
            Controls.Add(textBoxMessage);
            Controls.Add(label3);
            Controls.Add(buttonConnect);
            Controls.Add(textBoxYourName);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Client";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBox1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private TextBox textBoxYourName;
        private Button buttonConnect;
        private Label label3;
        private TextBox textBoxMessage;
        private Button buttonSend;
    }
}
