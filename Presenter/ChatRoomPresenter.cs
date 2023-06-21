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
            _chatRooms = DBManager.Instance.asdsad(_user.Id);
            /*foreach(var chatRoom in _chatRooms)
            {
                Console.WriteLine($"{chatRoom.Id}, {chatRoom.Name}:");
                foreach(var participant in chatRoom.Participants)
                {
                    Console.WriteLine($"\t{participant.Id}, {participant.Username}");
                }
            }*/
            return _chatRooms;
        }
        public ChatRoomPresenter(IChatRoomView view, User user)
        {
            _user = user;
            _view = view;
            //map actions
            view.LoadChat += LoadChat;
            view.SendNewMessage += SendNewMessage;
            //set username and email fields
            //_view.set_chatRoom_List(get_chatRooms()); DONE
            get_chatRooms();
            foreach (Model.ChatRoom chatRoom in _chatRooms)
            {
                _view.ChatRoom_List.Items.Add(chatRoom);
            }
        }

        private void LoadChat(long id)
        {
            try
            {
                /*ChatRoom chatRoom = _chatRooms[id];
                //TODO
                //zebrac z bazy wiadomości dla danej konwersacji 
                List<Model.Message> messages = new List<Model.Message>();*/

                foreach (var chatRoom in _chatRooms)
                {
                    if (chatRoom.Id == id)
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
                            //scroll down
                            _view.Chat_Panel.ScrollControlIntoView(_view.Chat_Panel.Controls[_view.Chat_Panel.Controls.Count - 1]);
                        }
                        //_view.set_chatPanel(chatRoom.Messages, _user.Username);
                    }

                }
            }
            catch (Exception ex)
            {
                //TODO
            }
        }

        private void SendNewMessage(int id, string new_message)
        {
            try
            {
                ChatRoom chatRoom = _chatRooms[id];
                var new_msg = new Model.Message { Content = new_message, Timestamp = DateTime.Now, Sender = _user };
                //to taki mój pomysl jak to wygladac by moglo w sumie
                //var new_msg = new Message { Content = new_message, Timestamp = DateTime.Now, Sender = _user, ChatRoom = chatRoom };

                //TODO dodać nową wiadomość do bazy

                //dodanie nowej wiadomośći do obecnej konwersacji
                //_view.add_to_chatPanel(new_msg, _user.Username);
            }
            catch (Exception ex)
            {
                //TODO
            }
        }
    }
}