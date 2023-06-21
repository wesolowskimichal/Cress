using Cress.Model;
using Cress.View.ChatRoom;
using Cress.View.UserSettings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress.Presenter
{
    public class ChatRoomPresenter
    {
        private readonly User _user;
        private readonly IChatRoomView _view;
        private List<Model.ChatRoom> _chatRooms;

        private List<Model.ChatRoom> get_chatRooms()
        {
            _chatRooms = DBManager.Instance.GetChatRoomsByUserID(_user.Id);
            return _chatRooms;
        }
        public ChatRoomPresenter(IChatRoomView view, User user)
        {
            _user = user;
            _view = view;
            view.LoadChat += LoadChat;
            view.SendNewMessage += SendNewMessage;
            get_chatRooms();
            foreach (Model.ChatRoom chatRoom in _chatRooms)
            {
                _view.ChatRoom_List.Items.Add(chatRoom);
            }
        }

        private void LoadChat(ChatRoom chatRoom)
        {
            try
            {
                _view.Chat_Panel.Controls.Clear();
                _view.Chat_Panel.Controls.Add(new Label { Text = "                                                                        ", AutoSize = true, Visible = true });
                foreach (Model.Message message in chatRoom.Messages)
                {
                    if (message.Sender.Id == _user.Id)
                    {
                        _view.Chat_Panel.Controls.Add(new Label { Text = $"{message.Content}", BackColor = Color.FromArgb(204, 255, 255), AutoSize = true, Anchor = AnchorStyles.Right });
                    }
                    else
                    {
                        _view.Chat_Panel.Controls.Add(new Label { Text = $"{message.Sender.Username}", AutoSize = true });
                        _view.Chat_Panel.Controls.Add(new Label { Text = $"{message.Content}", BackColor = Color.FromArgb(224, 224, 224), AutoSize = true });
                    }
                    _view.Chat_Panel.ScrollControlIntoView(_view.Chat_Panel.Controls[_view.Chat_Panel.Controls.Count - 1]);
                }
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void SendNewMessage(ChatRoom chatRoom, string new_message)
        {
            try
            {
                var new_msg = new Model.Message { Content = new_message, Timestamp = DateTime.Now, Sender = _user };
                DBManager.Instance.SendMessage(chatRoom, _user, new_message);
            }
            catch (Exception ex)
            {
                //TODO
            }
        }
    }
}