namespace ServerGoGame
{
    partial class FormServer
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            textBoxMaxUsers = new TextBox();
            textBoxMaxTables = new TextBox();
            buttonStart = new Button();
            buttonStop = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhco;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 119);
            label1.Name = "label1";
            label1.Size = new Size(351, 47);
            label1.TabIndex = 1;
            label1.Text = "SERVER GO GAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 184);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(392, 379);
            listBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 213);
            label2.Name = "label2";
            label2.Size = new Size(240, 25);
            label2.TabIndex = 3;
            label2.Text = "Số người chơi tối đa (1-300):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 276);
            label3.Name = "label3";
            label3.Size = new Size(209, 25);
            label3.TabIndex = 4;
            label3.Text = "Số bàn cờ tối đa (1-100):";
            // 
            // textBoxMaxUsers
            // 
            textBoxMaxUsers.Location = new Point(724, 210);
            textBoxMaxUsers.Name = "textBoxMaxUsers";
            textBoxMaxUsers.Size = new Size(43, 31);
            textBoxMaxUsers.TabIndex = 5;
            // 
            // textBoxMaxTables
            // 
            textBoxMaxTables.Location = new Point(724, 276);
            textBoxMaxTables.Name = "textBoxMaxTables";
            textBoxMaxTables.Size = new Size(43, 31);
            textBoxMaxTables.TabIndex = 6;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(582, 378);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(197, 61);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Connect";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(582, 483);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(197, 61);
            buttonStop.TabIndex = 8;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            // 
            // FormServer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 573);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(textBoxMaxTables);
            Controls.Add(textBoxMaxUsers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormServer";
            Text = "FormServer";
            Load += FormServer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private TextBox textBoxMaxUsers;
        private TextBox textBoxMaxTables;
        private Button buttonStart;
        private Button buttonStop;
    }
}
