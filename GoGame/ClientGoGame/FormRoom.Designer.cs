namespace ClientGoGame
{
    partial class FormRoom
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxLocal = new TextBox();
            textBoxServer = new TextBox();
            panel1 = new Panel();
            buttonConnect = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(453, 24);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "Local";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(453, 85);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 2;
            label3.Text = "Server:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(119, 24);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(249, 31);
            textBoxName.TabIndex = 3;
            // 
            // textBoxLocal
            // 
            textBoxLocal.Location = new Point(557, 24);
            textBoxLocal.Name = "textBoxLocal";
            textBoxLocal.Size = new Size(274, 31);
            textBoxLocal.TabIndex = 4;
            // 
            // textBoxServer
            // 
            textBoxServer.Location = new Point(557, 85);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(274, 31);
            textBoxServer.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 352);
            panel1.TabIndex = 6;
            // 
            // buttonConnect
            // 
            buttonConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConnect.Location = new Point(568, 364);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(181, 66);
            buttonConnect.TabIndex = 7;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(510, 152);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(321, 204);
            listBox1.TabIndex = 8;
            // 
            // FormRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 511);
            Controls.Add(listBox1);
            Controls.Add(buttonConnect);
            Controls.Add(panel1);
            Controls.Add(textBoxServer);
            Controls.Add(textBoxLocal);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRoom";
            Text = "Form Room";
            Load += FormRoom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxLocal;
        private TextBox textBoxServer;
        private Panel panel1;
        private Button buttonConnect;
        private ListBox listBox1;
    }
}
