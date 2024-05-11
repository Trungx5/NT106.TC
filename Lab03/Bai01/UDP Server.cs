using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
namespace Bai01
{
    public partial class UDP_Server : Form
    {
        public UDP_Server()
        {
            InitializeComponent();
        }
        private UdpClient udpCilent;
        private bool isListening;

        private void ServerThread()
        {
            while (isListening)
            {
                try
                {
                    IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] bytes = udpCilent.Receive(ref iPEndPoint);
                    string returnData = Encoding.UTF8.GetString(bytes);
                    string message = iPEndPoint.Address.ToString() + ": " + returnData.ToString() + "\n";
                    if(MessageRecieved__TextBox.InvokeRequired)
                    {
                        MessageRecieved__TextBox.Invoke(new MethodInvoker(delegate { MessageRecieved__TextBox.Text += message; }));
                    }
                    else
                    {
                        MessageRecieved__TextBox.Text += message;
                    }
                }
                catch (SocketException ex)
                {
                    if(isListening && ex.SocketErrorCode != SocketError.Interrupted)
                    {
                        throw;
                    }
                }
            }    
        }

        private void UDP_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            isListening = false;
            if(udpCilent != null)
            {
                udpCilent.Close();
            }
        }

        private void Listen_Button_Click(object sender, EventArgs e)
        {
           try
            {
                isListening = true;
                Thread thread = new Thread(new ThreadStart(ServerThread));
                udpCilent = new UdpClient(int.Parse(Port_TextBox.Text));
                thread.IsBackground = true;
                thread.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đúng địa chỉ Port!");
            }
            catch
            {

            }
        }
    }
}
