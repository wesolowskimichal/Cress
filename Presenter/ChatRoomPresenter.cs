using Cress.Model;
using Cress.View.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.Presenter
{
    public class ChatRoomPresenter
    {
        private readonly User _user;
        private readonly View.ChatRoom.ChatRoomView _view;
        private List<Model.ChatRoom> _chatRooms;

        private List<Model.ChatRoom> get_chatRooms()
        {
            //TODO
            //zaladowac czaty uzytkownika

            _chatRooms = new List<Model.ChatRoom>();
            return new List<Model.ChatRoom>();
        }
        public ChatRoomPresenter(View.ChatRoom.ChatRoomView view, User user)
        {
            _user = user;
            _view = view;
            //map actions
            view.LoadChat += LoadChat;
            view.SendNewMessage += SendNewMessage;
            //set username and email fields
            _view.set_chatRoom_List(get_chatRooms());
        }

        private void LoadChat(int id)
        {
            try
            {
                ChatRoom chatRoom = _chatRooms[id];
                //TODO
                //zebrac z bazy wiadomości dla danej konwersacji
                List<Model.Message> messages = new List<Model.Message>();
                _view.set_chatPanel(messages, _user.Username);
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
                var new_msg = new Message { Content = new_message, Timestamp = DateTime.Now, Sender = _user };
                //to taki mój pomysl jak to wygladac by moglo w sumie
                //var new_msg = new Message { Content = new_message, Timestamp = DateTime.Now, Sender = _user, ChatRoom = chatRoom };

                //TODO dodać nową wiadomość do bazy

                //dodanie nowej wiadomośći do obecnej konwersacji
                _view.add_to_chatPanel(new_msg, _user.Username);
            }
            catch (Exception ex)
            {
                //TODO
            }
        }
    }
}