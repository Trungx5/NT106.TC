using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace SLLChat
{
    
    internal class ServerConnection
    {
        TcpListener listener;
        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;

        
        public ServerConnection()
        {
            listener = new TcpListener(IPAddress.Any, 1234);
            listener.Start();
            client = listener.AcceptTcpClient();
            ns = client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            sw.AutoFlush = true;
        }
        
        
        public void SendMessage(string message)
        {
            sw.WriteLine(message);
        }
        
        public string ReceiveMessage()
        {
            return sr.ReadLine();
        }
        public void Close() { }

    }
}
