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
        public CreateChatRoomView()
        {
            InitializeComponent();
        }

        private void CreateChtRm_Btn_Click(object sender, EventArgs e)
        {
            string chatName = newChatName.Text;
            var userList = new List<Model.User>();
            for (int i = 0; i < UserListBox.Items.Count; i++)
            {
                if (UserListBox.GetItemChecked(i))
                {
                    userList.Add(UserListBox.Items[i] as Model.User);
                }
                UserListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            // send to presenter
            CreateNewChatRoom?.Invoke(chatName, userList);

        }

        //metody publiczne przeznaczone dla presentera

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
                string s = "";
                foreach (var user in chatRoom.Participants)
                {
                    s += user.Username + ", ";
                }
                ChatListBox.Items.Add($"{chatRoom.Name} - {s}");
            }
        }
    }
}
