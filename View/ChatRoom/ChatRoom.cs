using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress.View.ChatRoom
{
    public partial class ChatRoom : UserControl
    {
        public ChatRoom()
        {
            InitializeComponent();
            chat_Panel.Controls.Add(new Label { Text = "                                                                              ", AutoSize = true, Visible = true });
            for (int i = 0; i < 100; i++)
            {
                chat_Panel.Controls.Add(new Label { Text = $"Other user", AutoSize = true });
                chat_Panel.Controls.Add(new Label { Text = $"new message (other user) {i}", BackColor = Color.FromArgb(224, 224, 224), AutoSize = true });
                var x = new Label { Text = $"new message (you) {i}", BackColor = Color.FromArgb(204, 255, 255), AutoSize = true, Anchor = AnchorStyles.Right };
                chat_Panel.Controls.Add(x);
            }
            //to sie nam scroluje na sam dół
            chat_Panel.ScrollControlIntoView(chat_Panel.Controls[chat_Panel.Controls.Count - 1]);
        }

        public event Action<string> SendNewMessage;
        public event Action<int> LoadChat;

        private void chatRoom_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = chatRoom_List.SelectedIndex;
            if (position != -1)
            {
                LoadChat?.Invoke(position);
            }
        }

        private void send_Btn_Click(object sender, EventArgs e)
        {
            if (new_message_In.Text.Length > 0)
            {
                SendNewMessage?.Invoke(new_message_In.Text);
                //add new message

                //clear input
                new_message_In.Text = "";
            }
        }

        // publiczne metody

        public void set_chatRoom_List(List<ChatRoom> chatRooms)
        {
            foreach (ChatRoom chatRoom in chatRooms)
            {
                chatRoom_List.Items.Add(chatRoom.ToString());
            }
        }

        public void set_chat_Panel(List<Model.Message> messages, string current_user)
        {
            foreach (Model.Message message in messages)
            {
                if (message.Sender.Username == current_user)
                {
                    chat_Panel.Controls.Add(new Label { Text = $"{message.Content}", BackColor = Color.FromArgb(204, 255, 255), AutoSize = true, Anchor = AnchorStyles.Right });
                }
                else
                {
                    chat_Panel.Controls.Add(new Label { Text = $"{message.Sender.Username}", AutoSize = true });
                    chat_Panel.Controls.Add(new Label { Text = $"{message.Content}", BackColor = Color.FromArgb(224, 224, 224), AutoSize = true });
                }
                //scroll down
                chat_Panel.ScrollControlIntoView(chat_Panel.Controls[chat_Panel.Controls.Count - 1]);
            }
        }
    }
}
