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
    public partial class Server : Form
    {
        TcpListener listener;
        List<TcpClient> clients = new List<TcpClient>();
        private void ServerConnect_Button_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Parse(IP_TextBox.Text), int.Parse(Port_TextBox.Text));
            listener.Start();
            MessageContent_RTextBox.Text += "Server is running at port " + Port_TextBox.Text + "\n";

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client);
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.Start(client);
                }
            });
            thread.Start();
        }
        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            while (true)
            {
                string data = reader.ReadLine();
                Invoke((MethodInvoker)delegate
                {
                    MessageContent_RTextBox.Text += "Client: " + data + "\n";
                });

                foreach (TcpClient otherClient in clients)
                {
                    if (otherClient != client)
                    {
                        StreamWriter otherWriter = new StreamWriter(otherClient.GetStream());
                        otherWriter.AutoFlush = true;
                        otherWriter.WriteLine(data);
                    }
                }
            }
        }

        private void Server_Disconnect_Button_Click(object sender, EventArgs e)
        {
            foreach (TcpClient client in clients)
            {
                client.Close();
            }
            listener.Stop();
        }

        public Server()
        {
            InitializeComponent();
            
        } 

       
    }
}
