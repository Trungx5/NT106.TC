using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormPrivateChat : Form
    {
        /*public FormPrivateChat()
        {
            InitializeComponent();
        }*/

        private string NameFriend;
        private User user;

        public FormPrivateChat(string friend, User userr)
        {
            NameFriend = friend;
            this.user = userr;
            // this.client = clientt;
            //this.Name = namee;
            InitializeComponent();

        }

        private void FormPrivateChat_Load(object sender, EventArgs e)
        {
            label1.Text = "Chat with " + NameFriend;
        }

        private delegate void RichTextBoxDelegage(string str);

        public void AddItemToRichTextBox(string str)
        {
            if (richTextBoxPrivate.InvokeRequired)
            {
                RichTextBoxDelegage d = AddItemToRichTextBox;
                richTextBoxPrivate.Invoke(d, str);

            }
            else
            {
                richTextBoxPrivate.Text += str + '\n';
            }
        }

        private void buttonSendPrivate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMessagePrivate.Text))
            {
                return;
            }
            string messageSend = textBoxMessagePrivate.Text;


            user.Writer.WriteLine("PRIVATE" + "," + user.Name);
            user.Writer.WriteLine(this.NameFriend);
            user.Writer.WriteLine(this.NameFriend + user.Name);
            user.Writer.WriteLine(messageSend);
            AddItemToRichTextBox("Me : " + messageSend);
            textBoxMessagePrivate.Text = "";
        }
    }

}
