using System.Net.Sockets;
using System.Net;

namespace Client
{
    public partial class Form1 : Form
    {

        private User user;
        private FormPrivateChat formPrivateChat;
        private List<FormPrivateChat> formPrivateChats = new List<FormPrivateChat>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            user = new User();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            user.Client = new TcpClient();
            user.Client.Connect(iPEndPoint);
            NetworkStream networkStream = user.Client.GetStream();
            user.Reader = new StreamReader(networkStream);
            user.Writer = new StreamWriter(networkStream);
            user.Writer.AutoFlush = true;
            user.Name = textBoxYourName.Text;
            //addd
            user.Writer.WriteLine(user.Name);
            string command = user.Reader.ReadLine();
            if (command == "isExist")
            {
                MessageBox.Show("Tên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user.Client.Close();
                user.Reader.Close();
                user.Writer.Close();
                user = null;

                return;
            }
            //
            Thread threadRecive = new Thread(RecieveData);
            threadRecive.IsBackground = true;
            threadRecive.Start();
            buttonConnect.Enabled = false;
            textBoxYourName.Enabled = false;
            user.Writer.WriteLine(user.Name);
        }

        private void RecieveData()
        {
            while (true)
            {

                try
                {
                    string? recieveString = user.Reader.ReadLine();//streamReader.ReadLine();

                    if (recieveString == null)
                    {
                        return;
                    }
                    var parts = recieveString?.Split(",");

                    string command = parts[0];
                    string name = parts[1];


                    switch (command)
                    {
                        case "ALL":
                            string? message = user.Reader.ReadLine();//streamReader.ReadLine();
                            if (user.Name != name)
                            {
                                AddItemToRichTextBox(name + " : " + message);
                            }

                            break;
                        case "LIST":
                            string? DsName = user.Reader.ReadLine();//streamReader.ReadLine();
                            AddItemToListBox(DsName);

                            break;

                        case "PRIVATE":

                            string? nameFormPrivateChat = user.Reader.ReadLine();

                            message = user.Reader.ReadLine();
                            //AddItemToRichTextBox(name + " : " + message);
                            // formPrivateChat.AddItemToRichTextBox(name+" : "+message);
                            foreach (var item in formPrivateChats)
                            {
                                if (item.Name == nameFormPrivateChat)
                                {
                                    item.AddItemToRichTextBox(name + " : " + message);
                                }
                            }
                            break;
                    }
                }
                catch
                {

                }


            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMessage.Text))
            {
                return;
            }
            string messageSend = textBoxMessage.Text;
            user.Writer.WriteLine("ALL" + "," + user.Name);
            user.Writer.WriteLine(messageSend);
            AddItemToRichTextBox("Me : " + messageSend);
            textBoxMessage.Text = "";
        }

        private delegate void RichTextBoxDelegage(string str);

        private void AddItemToRichTextBox(string str)
        {
            if (richTextBox1.InvokeRequired)
            {
                RichTextBoxDelegage d = AddItemToRichTextBox;
                richTextBox1.Invoke(d, str);

            }
            else
            {
                richTextBox1.Text += str + '\n';
            }
        }

        private delegate void ListBoxDelegate(string str);

        private void AddItemToListBox(string str)
        {
            if (listBox1.InvokeRequired)
            {
                ListBoxDelegate d = AddItemToListBox;
                listBox1.Invoke(d, str);
            }
            else
            {
                listBox1.Items.Clear();
                string[] partNames = str.Split(",");
                foreach (string partName in partNames)
                {
                    if (partName != user.Name)
                    {
                        listBox1.Items.Add(partName);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string friend = listBox1.SelectedItem.ToString();
            formPrivateChat = new FormPrivateChat(friend, this.user);
            formPrivateChat.Name = user.Name + friend;
            formPrivateChats.Add(formPrivateChat);
            formPrivateChat.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (user != null)
            {
                user.Writer.WriteLine("LISTOUT," + user.Name);
                user.Writer.WriteLine(user.Name);
                //
                user.Client.Close();
            }
        }

       
    }
}
