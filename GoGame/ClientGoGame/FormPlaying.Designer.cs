namespace ClientGoGame
{
    partial class FormPlaying
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            buttonReady = new Button();
            labelSide = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            buttonSkip = new Button();
            panel2 = new Panel();
            labelPrisonser2 = new Label();
            labelScore2 = new Label();
            pictureBox2 = new PictureBox();
            labelName2 = new Label();
            panel3 = new Panel();
            labelPrisonser1 = new Label();
            labelScore1 = new Label();
            labelName1 = new Label();
            TimerPlayer1 = new System.Windows.Forms.Timer(components);
            TimerPlayer2 = new System.Windows.Forms.Timer(components);
            TimerP2_Label = new Label();
            TimerPlayer1_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 640);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // buttonReady
            // 
            buttonReady.Anchor = AnchorStyles.Bottom;
            buttonReady.Location = new Point(354, 65);
            buttonReady.Name = "buttonReady";
            buttonReady.Size = new Size(96, 36);
            buttonReady.TabIndex = 0;
            buttonReady.Text = "Ready";
            buttonReady.UseVisualStyleBackColor = true;
            buttonReady.Click += buttonReady_Click;
            // 
            // labelSide
            // 
            labelSide.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSide.AutoSize = true;
            labelSide.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSide.Location = new Point(1128, 22);
            labelSide.Name = "labelSide";
            labelSide.Size = new Size(65, 28);
            labelSide.TabIndex = 1;
            labelSide.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1036, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 229);
            listBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonSkip
            // 
            buttonSkip.Location = new Point(378, 8);
            buttonSkip.Name = "buttonSkip";
            buttonSkip.Size = new Size(72, 36);
            buttonSkip.TabIndex = 4;
            buttonSkip.Text = "Skip Turn";
            buttonSkip.UseVisualStyleBackColor = true;
            buttonSkip.Click += buttonSkip_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelPrisonser2);
            panel2.Controls.Add(labelScore2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(labelName2);
            panel2.Location = new Point(769, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 110);
            panel2.TabIndex = 5;
            // 
            // labelPrisonser2
            // 
            labelPrisonser2.AutoSize = true;
            labelPrisonser2.Location = new Point(143, 14);
            labelPrisonser2.Name = "labelPrisonser2";
            labelPrisonser2.Size = new Size(22, 25);
            labelPrisonser2.TabIndex = 9;
            labelPrisonser2.Text = "0";
            // 
            // labelScore2
            // 
            labelScore2.AutoSize = true;
            labelScore2.Location = new Point(142, 68);
            labelScore2.Name = "labelScore2";
            labelScore2.Size = new Size(60, 25);
            labelScore2.TabIndex = 8;
            labelScore2.Text = "Score:";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(9, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // labelName2
            // 
            labelName2.AutoSize = true;
            labelName2.Location = new Point(9, 68);
            labelName2.Name = "labelName2";
            labelName2.Size = new Size(61, 25);
            labelName2.TabIndex = 0;
            labelName2.Text = "Friend";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelPrisonser1);
            panel3.Controls.Add(labelScore1);
            panel3.Controls.Add(labelName1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(buttonSkip);
            panel3.Controls.Add(buttonReady);
            panel3.Location = new Point(769, 604);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 112);
            panel3.TabIndex = 6;
            // 
            // labelPrisonser1
            // 
            labelPrisonser1.AutoSize = true;
            labelPrisonser1.Location = new Point(126, 20);
            labelPrisonser1.Name = "labelPrisonser1";
            labelPrisonser1.Size = new Size(22, 25);
            labelPrisonser1.TabIndex = 7;
            labelPrisonser1.Text = "0";
            // 
            // labelScore1
            // 
            labelScore1.AutoSize = true;
            labelScore1.Location = new Point(126, 76);
            labelScore1.Name = "labelScore1";
            labelScore1.Size = new Size(60, 25);
            labelScore1.TabIndex = 6;
            labelScore1.Text = "Score:";
            // 
            // labelName1
            // 
            labelName1.AutoSize = true;
            labelName1.Location = new Point(11, 71);
            labelName1.Name = "labelName1";
            labelName1.Size = new Size(41, 25);
            labelName1.TabIndex = 5;
            labelName1.Text = "You";
            // 
            // TimerPlayer1
            // 
            TimerPlayer1.Enabled = true;
            TimerPlayer1.Interval = 30000;
            TimerPlayer1.Tick += TimerPlayer1_Tick_1;
            // 
            // TimerPlayer2
            // 
            TimerPlayer2.Enabled = true;
            TimerPlayer2.Interval = 30000;
            TimerPlayer2.Tick += TimerPlayer2_Tick;
            // 
            // TimerP2_Label
            // 
            TimerP2_Label.AutoSize = true;
            TimerP2_Label.Location = new Point(777, 123);
            TimerP2_Label.Name = "TimerP2_Label";
            TimerP2_Label.Size = new Size(59, 25);
            TimerP2_Label.TabIndex = 7;
            TimerP2_Label.Text = "label1";
            // 
            // TimerPlayer1_Label
            // 
            TimerPlayer1_Label.AutoSize = true;
            TimerPlayer1_Label.Location = new Point(769, 576);
            TimerPlayer1_Label.Name = "TimerPlayer1_Label";
            TimerPlayer1_Label.Size = new Size(59, 25);
            TimerPlayer1_Label.TabIndex = 8;
            TimerPlayer1_Label.Text = "label1";
            // 
            // FormPlaying
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 726);
            Controls.Add(TimerPlayer1_Label);
            Controls.Add(TimerP2_Label);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(labelSide);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "FormPlaying";
            Padding = new Padding(10);
            Text = "FormPlaying";
            Load += FormPlaying_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonReady;
        private Label labelSide;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button buttonSkip;
        private Panel panel2;
        private Panel panel3;
        private Label labelName1;
        private PictureBox pictureBox2;
        private Label labelName2;
        private Label labelScore2;
        private Label labelScore1;
        private Label labelPrisonser2;
        private Label labelPrisonser1;
        private System.Windows.Forms.Timer TimerPlayer1;
        private System.Windows.Forms.Timer TimerPlayer2;
        private Label TimerP2_Label;
        private Label TimerPlayer1_Label;
    }
}