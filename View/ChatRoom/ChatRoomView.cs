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
    public partial class ChatRoomView : UserControl, IChatRoomView
    {
        #region Implementation of IChatRoomView
        public ListBox ChatRoom_List => chatRoom_List;
        public FlowLayoutPanel Chat_Panel => chat_Panel;

        public event Action<int, string> SendNewMessage;
        public event Action<long> LoadChat;
        #endregion
        public ChatRoomView()
        {
            InitializeComponent();
            /// wypełniacz żeby bylo widać jak to s obie wymyśliłem
            /*chat_Panel.Controls.Add(new Label { Text = "                                                                              ", AutoSize = true, Visible = true });
            for (int i = 0; i < 100; i++)
            {
                chat_Panel.Controls.Add(new Label { Text = $"Other user", AutoSize = true });
                chat_Panel.Controls.Add(new Label { Text = $"new message (other user) {i}", BackColor = Color.FromArgb(224, 224, 224), AutoSize = true });
                var x = new Label { Text = $"new message (you) {i}", BackColor = Color.FromArgb(204, 255, 255), AutoSize = true, Anchor = AnchorStyles.Right };
                chat_Panel.Controls.Add(x);
            }
            chat_Panel.ScrollControlIntoView(chat_Panel.Controls[chat_Panel.Controls.Count - 1]);*/
            ///
        }

        private void chatRoom_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = chatRoom_List.SelectedIndex;
            if (position != -1)
            {
                Model.ChatRoom cr = chatRoom_List.SelectedItem as Model.ChatRoom;
                LoadChat?.Invoke(cr.Id);
            }
        }

        private void send_Btn_Click(object sender, EventArgs e)
        {
            if (new_message_In.Text.Length > 0 && chatRoom_List.SelectedIndex != -1)
            {
                SendNewMessage?.Invoke(chatRoom_List.SelectedIndex, new_message_In.Text);
                //add new message

                //clear input
                new_message_In.Text = "";
            }
        }

        // publiczne metody

        /*public void set_chatRoom_List(List<Model.ChatRoom> chatRooms)
        {
            foreach (Model.ChatRoom chatRoom in chatRooms)
            {
                chatRoom_List.Items.Add(chatRoom);
            }
        }*/

       /* public void add_to_chatPanel(Model.Message message, string current_user)
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
        }

        public void set_chatPanel(List<Model.Message> messages, string current_user)
        {
            //nastepna linijka jest tylko po to żeby widok czatu sie dobrze formatował xd
            chat_Panel.Controls.Clear();
            chat_Panel.Controls.Add(new Label { Text = "                                                                        ", AutoSize = true, Visible = true });
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
        }*/
    }
}