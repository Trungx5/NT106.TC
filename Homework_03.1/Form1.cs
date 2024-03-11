using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_03._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog foldbd = new FolderBrowserDialog() { Description="Chọn đường dẫn: "})
            {
                if(foldbd.ShowDialog()==DialogResult.OK)
                {
                    FileBrowser.Url = new Uri(foldbd.SelectedPath);
                    PathText.Text = foldbd.SelectedPath;
                }    
            }    
        }

        private void FileBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void PathText_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(FileBrowser.CanGoBack==true)
            {
                FileBrowser.GoBack();
            }    
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if(FileBrowser.CanGoForward==true)
            {
                FileBrowser.GoForward();
            }    
        }
        private async void CopyLargeFile(string sourcePath, string destinationPath)
        {
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
                {
                    await sourceStream.CopyToAsync(destinationStream);
                }
            }
        }

    }
}
