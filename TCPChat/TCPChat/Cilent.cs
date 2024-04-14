using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace SLLChat
{
    public partial class Cilent : Form
    {

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private string username;
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
        public Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        private void ServerConnect_Button_Cilent_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            client.Connect(IPAddress.Parse(IP_TextBox_Cilent.Text), int.Parse(Port_TextBox_Cilent.Text));
            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            writer.AutoFlush = true;
            username = UserName_Input.Text;
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    string data = reader.ReadLine();
                    if (data.StartsWith("img:"))
                    {
                        Image image = Base64ToImage(data.Substring(4));
                        Invoke((MethodInvoker)delegate
                        {
                            PictureBox_Message.Image = image;
                        });
                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            MessageContent_RTextBox_Cilent.Text += data + "\n";
                        });
                    }
                }
                });
            thread.Start();
        }

        
        public Cilent()
        {
            InitializeComponent();
        }

        private void Server_Disconnect_Button_Cilent_Click_1(object sender, EventArgs e)
        {
            client.Close();
        }

        private void Send_Msg_Cilent_Click_1(object sender, EventArgs e)
        {
           string message = username + ": " + Message_Send_Content_Cilent_RichTextBox.Text;
            writer.WriteLine(message);
            MessageContent_RTextBox_Cilent.Text += "You: " + Message_Send_Content_Cilent_RichTextBox.Text + "\n";
            Message_Send_Content_Cilent_RichTextBox.Text = "";
        }

        private void ImageAdd_Button_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    Image resizedImage = ResizeImage(image, 800, 600); 
                    string base64Image = ImageToBase64(resizedImage);
                    string message = username + ": img:\n" + base64Image;
                    writer.WriteLine(message);
                }
                
        }

        private void PictureBox_Message_Click(object sender, EventArgs e)
        {

        }
    }
}
