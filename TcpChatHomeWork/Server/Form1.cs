using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class Form1 : Form
    {

        private TcpListener myListener;
        private List<User> listUsers = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {

            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 8080);
            myListener = new TcpListener(iPEndPoint);
            myListener.Start();

            Thread myTheard = new Thread(ListenerConnection);
            myTheard.IsBackground = true;
            myTheard.Start();
            buttonListen.Enabled = false;
        }

        private void ListenerConnection()
        {
            while (true)
            {

                TcpClient newClient = null;
                try
                {
                    newClient = myListener.AcceptTcpClient();

                }
                catch
                {

                }

                User newUser = new User();
                newUser.Client = newClient;
                NetworkStream networkStream = newUser.Client.GetStream();
                newUser.Writer = new StreamWriter(networkStream);
                newUser.Reader = new StreamReader(networkStream);
                newUser.Writer.AutoFlush = true;
                //add

                string NameOfUser = newUser.Reader.ReadLine();
                bool exits = false;
                foreach (var user in listUsers)
                {
                    if (user.Name == NameOfUser)
                    {
                        newUser.Writer.WriteLine("isExist");
                        exits = true;

                        //them
                        newUser.Client.Close();
                        break;
                    }
                }
                if (!exits)
                {
                    newUser.Writer.WriteLine("isnotExist");

                    //
                    listUsers.Add(newUser);

                    Thread threadReceiveData = new Thread(ReceiveData);
                    threadReceiveData.IsBackground = true;
                    threadReceiveData.Start(newUser);
                }



            }
        }

        private void ReceiveData(object obj)
        {
            User user = (User)obj;
            string notificationConnect = $"New client connect from {user.Client.Client.RemoteEndPoint}";
            AddItemToListBox(notificationConnect);

            string? nameUser = user.Reader.ReadLine();
            user.Name = nameUser;
            //listNameClient.Add(nameClient);
            SendListClient(nameUser);

            while (true)
            {
                string? reciveString = user.Reader.ReadLine();//streamReader.ReadLine();

                var parts = reciveString?.Split(",");
                string command = parts[0];
                string name = parts[1];
                string? message;
                switch (command)
                {
                    case "ALL":

                        message = user.Reader.ReadLine();//streamReader.ReadLine();
                        AddItemToListBox("ALL " + name + " : " + message);
                        SendToAllClient(name, message);


                        break;


                    case "PRIVATE":

                        string? friend = user.Reader.ReadLine();
                        string? nameFormPrivateChat = user.Reader.ReadLine();
                        message = user.Reader.ReadLine();
                        AddItemToListBox("PRIVATE " + name + " : " + message);
                        SendOnlyFriend(name, message, friend, nameFormPrivateChat);

                        break;
                    case "LISTOUT":
                        string? nameUserOut = user.Reader.ReadLine();
                        listUsers.RemoveAll(user => user.Name == nameUserOut);
                        SendListClient(nameUserOut);

                        user.Reader.Close();
                        user.Writer.Close();
                        user.Client.Close();

                        return;
                        //break;



                }

            }

        }

        private delegate void ListboxDelagate(string str);

        private void AddItemToListBox(string str)
        {
            if (listBox1.InvokeRequired)
            {
                ListboxDelagate d = AddItemToListBox;
                listBox1.Invoke(d, str);

            }
            else
            {
                listBox1.Items.Add(str);
            }
        }

        private void SendToAllClient(string name, string message)
        {

            foreach (var eachUser in listUsers)
            {
                eachUser.Writer.WriteLine($"ALL,{name}");
                eachUser.Writer.WriteLine(message);
            }


        }

        private void SendListClient(string name)
        {
            List<string> nameUser = new List<string>();
            foreach (var eachUser in listUsers)
            {
                nameUser.Add(eachUser.Name);
            }
            string content = string.Join(",", nameUser.ToArray());
            foreach (var eachUser in listUsers)
            {
                eachUser.Writer.WriteLine("LIST," + name);
                eachUser.Writer.WriteLine(content);

            }
        }

        private void SendOnlyFriend(string name, string message, string friend, string nameFormPrivateChat)
        {
            foreach (var eachUser in listUsers)
            {
                if (eachUser.Name == friend)
                {
                    eachUser.Writer.WriteLine("PRIVATE," + name);
                    eachUser.Writer.WriteLine(nameFormPrivateChat);
                    eachUser.Writer.WriteLine(message);
                }


            }

        }

    }
}
