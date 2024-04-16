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
            panel1 = new Panel();
            buttonReady = new Button();
            labelSide = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 527);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // buttonReady
            // 
            buttonReady.Anchor = AnchorStyles.Bottom;
            buttonReady.Location = new Point(775, 481);
            buttonReady.Name = "buttonReady";
            buttonReady.Size = new Size(149, 58);
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
            labelSide.Location = new Point(938, 12);
            labelSide.Name = "labelSide";
            labelSide.Size = new Size(65, 28);
            labelSide.TabIndex = 1;
            labelSide.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(716, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 304);
            listBox1.TabIndex = 2;
            // 
            // FormPlaying
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 551);
            Controls.Add(listBox1);
            Controls.Add(labelSide);
            Controls.Add(buttonReady);
            Controls.Add(panel1);
            Name = "FormPlaying";
            Text = "FormPlaying";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonReady;
        private Label labelSide;
        private ListBox listBox1;
    }
}