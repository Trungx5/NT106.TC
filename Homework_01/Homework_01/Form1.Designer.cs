namespace Homework_01
{
    partial class PictureViewer
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
            components = new System.ComponentModel.Container();
            PictureShow = new PictureBox();
            menuStrip1 = new MenuStrip();
            FileMainFunc = new ToolStripMenuItem();
            OpenFunc = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            ImageLibrary = new ListView();
            ((System.ComponentModel.ISupportInitialize)PictureShow).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PictureShow
            // 
            PictureShow.Location = new Point(12, 202);
            PictureShow.Name = "PictureShow";
            PictureShow.Size = new Size(1547, 548);
            PictureShow.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureShow.TabIndex = 1;
            PictureShow.TabStop = false;
            PictureShow.Click += PictureShow_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileMainFunc });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1571, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileMainFunc
            // 
            FileMainFunc.DropDownItems.AddRange(new ToolStripItem[] { OpenFunc });
            FileMainFunc.Name = "FileMainFunc";
            FileMainFunc.Size = new Size(37, 20);
            FileMainFunc.Text = "File";
            FileMainFunc.Click += FileMainFunc_Click;
            // 
            // OpenFunc
            // 
            OpenFunc.Name = "OpenFunc";
            OpenFunc.Size = new Size(103, 22);
            OpenFunc.Text = "Open";
            OpenFunc.Click += OpenFunc_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // ImageLibrary
            // 
            ImageLibrary.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ImageLibrary.Location = new Point(12, 23);
            ImageLibrary.Name = "ImageLibrary";
            ImageLibrary.Size = new Size(1547, 173);
            ImageLibrary.SmallImageList = imageList1;
            ImageLibrary.TabIndex = 2;
            ImageLibrary.UseCompatibleStateImageBehavior = false;
            ImageLibrary.SelectedIndexChanged += ImageLibrary_SelectedIndexChanged;
            // 
            // PictureViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 762);
            Controls.Add(ImageLibrary);
            Controls.Add(PictureShow);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PictureViewer";
            Text = "PictureViewer";
            ((System.ComponentModel.ISupportInitialize)PictureShow).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMainFunc;
        private ToolStripMenuItem OpenFunc;
        private ImageList imageList1;
        private PictureBox PictureShow;
        private ListView ImageLibrary;
    }
}