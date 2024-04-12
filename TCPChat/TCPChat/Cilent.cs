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
namespace SLLChat
{
    public partial class Cilent : Form
    {
         private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private string username;
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
                    data = data.Replace("Server: ", ""); 
                    Invoke((MethodInvoker)delegate
                    {
                        MessageContent_RTextBox_Cilent.Text += data + "\n";
                    });
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
    }
}
