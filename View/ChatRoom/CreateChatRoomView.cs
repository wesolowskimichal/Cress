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

namespace Cress.View
{
    public partial class CreateChatRoomView : UserControl
    {
        public event Action<string, List<Model.User>> CreateNewChatRoom;
        public event Action<int> LeaveChatRoom;
        public event Action<int, string, List<Model.User>> UpdateChatRoom;
        public CreateChatRoomView()
        {
            InitializeComponent();
            LeaveChatRoomBtn.Visible = false;
            EditChatRoomBtn.Visible = false;
        }

        private List<Model.User> GetCheckedUsers()
        {
            var userList = new List<Model.User>();
            for (int i = 0; i < UserListBox.Items.Count; i++)
            {
                if (UserListBox.GetItemChecked(i))
                {
                    userList.Add(UserListBox.Items[i] as Model.User);
                }
                UserListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
            return userList;
        }

        private void CreateChtRm_Btn_Click(object sender, EventArgs e)
        {
            string chatName = newChatName.Text;
            var userList = GetCheckedUsers();

            // send to presenter
            CreateNewChatRoom?.Invoke(chatName, userList);

            newChatName.Text = "";

        }

        private void ChatListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChatListBox.SelectedItem != null)
            {
                CreateChtRm_Btn.Visible = false;
                LeaveChatRoomBtn.Visible = true;
                EditChatRoomBtn.Visible = true;
                newChatName.Text = ChatListBox.SelectedItem.ToString();

                for (int i = 0; i < UserListBox.Items.Count; i++)
                {
                    if ((ChatListBox.Items[ChatListBox.SelectedIndex] as Model.ChatRoom).Participants.Contains(UserListBox.Items[i]))
                    {
                        UserListBox.SetItemCheckState(i, CheckState.Checked);
                    }
                    else
                    {
                        UserListBox.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }

        private void LeaveChatRoom_Click(object sender, EventArgs e)
        {
            LeaveChatRoom?.Invoke(ChatListBox.SelectedIndex);
            //clear form
            CreateChtRm_Btn.Visible = true;
            LeaveChatRoomBtn.Visible = false;
            EditChatRoomBtn.Visible = false;
            newChatName.Text = "";
            ChatListBox.ClearSelected();
        }

        private void EditChatRoomBtn_Click(object sender, EventArgs e)
        {
            //get checked users
            var userList = GetCheckedUsers();

            UpdateChatRoom?.Invoke(ChatListBox.SelectedIndex, newChatName.Text, userList);
            //clear form
            CreateChtRm_Btn.Visible = true;
            LeaveChatRoomBtn.Visible = false;
            EditChatRoomBtn.Visible = false;
            newChatName.Text = "";
            ChatListBox.ClearSelected();
        }

        //metody publiczne przeznaczone dla prezentera

        public void SetUserListBox(List<Model.User> users)
        {
            foreach (var user in users)
            {
                UserListBox.Items.Add(user);
            }
        }

        public void SetChatListBox(List<Model.ChatRoom> chatRooms)
        {
            ChatListBox.Items.Clear();
            foreach (var chatRoom in chatRooms)
            {
                ChatListBox.Items.Add(chatRoom);
            }
        }
    }
}
