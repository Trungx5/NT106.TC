using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework_01
{
    public partial class PictureViewer : Form
    {
        private ImageList imageList;
        private string[] imageFiles;
        public PictureViewer()
        {
            InitializeComponent();
            imageList = new ImageList();
            imageList.ImageSize = new Size(255, 255);
            ImageLibrary.LargeImageList = imageList;
        }

        private void OpenFunc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chon file";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFiles = openFileDialog.FileNames;
                imageList.Images.Clear();
                ImageLibrary.Items.Clear();
                foreach (var file in imageFiles)
                {
                    var image = Image.FromFile(file);
                    imageList.Images.Add(image);
                    var item = new ListViewItem { ImageIndex = imageList.Images.Count - 1 };
                    ImageLibrary.Items.Add(item);
                }
            }

        }

        private void FileMainFunc_Click(object sender, EventArgs e)
        {

        }

        private void PictureShow_Click(object sender, EventArgs e)
        {
            
        }

        private void ImageLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImageLibrary.SelectedIndices.Count > 0)
            {
                PictureShow.Image = imageList.Images[ImageLibrary.SelectedIndices[0]];
            }
        }
    }
}