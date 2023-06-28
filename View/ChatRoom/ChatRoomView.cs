using Cress.Model;
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
        public int CurrentChatRoomIdx => chatRoom_List.SelectedIndex;

        public event Action<Model.ChatRoom, string> SendNewMessage;
        public event Action<Model.ChatRoom> LoadChat;
        public void Invoke(Action action)
        {
            try
            {
                this.BeginInvoke(action);
            }
            catch
            {
                Environment.Exit(0);
            }
        }
        #endregion

        public ChatRoomView()
        {
            InitializeComponent();
        }

        private void chatRoom_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = chatRoom_List.SelectedIndex;
            if (position != -1)
            {
                Model.ChatRoom cr = chatRoom_List.SelectedItem as Model.ChatRoom;
                LoadChat?.Invoke(cr);
            }
        }

        private void send_Btn_Click(object sender, EventArgs e)
        {
            if (new_message_In.Text.Length > 0 && chatRoom_List.SelectedIndex != -1)
            {
                Model.ChatRoom cr = chatRoom_List.SelectedItem as Model.ChatRoom;
                SendNewMessage?.Invoke(cr, new_message_In.Text);
                new_message_In.Text = "";
            }
        }
    }
}