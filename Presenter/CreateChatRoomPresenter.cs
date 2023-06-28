using Cress.Model;
using Cress.View;
using Cress.View.ChatRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress.Presenter
{
    public class CreateChatRoomPresenter
    {
        private Action showManage;
        private readonly User _user;
        private List<ChatRoom> _chatRooms;
        private List<User> _users;
        private readonly CreateChatRoomView _view;

        private List<ChatRoom> GetChatRooms()
        {
            _chatRooms = DBManager.Instance.GetChatRoomsByUserID(_user.Id);
            return _chatRooms;
        }

        private List<User> GetUsers()
        {
            _users = DBManager.Instance.GetAllUsers(_user.Id);
            return _users;
        }

        public CreateChatRoomPresenter(CreateChatRoomView view, User user, Action showManage)
        {
            this.showManage = showManage;
            _user = user;
            _view = view;
            _chatRooms = GetChatRooms();
            _users = GetUsers();

            _view.CreateNewChatRoom += CreateNewChatRoom;
            _view.LeaveChatRoom += LeaveChatRoom;
            _view.UpdateChatRoom += UpdateChatRoom;
            _view.ManageClick += ShowManage;
            //load chats
            _view.SetChatListBox(_chatRooms);
            _view.SetUserListBox(_users);
        }

        private void ShowManage()
        {
            _chatRooms = GetChatRooms();
            showManage();
        }

        private void CreateNewChatRoom(string chatName, List<User> chatUsers)
        {
            chatUsers.Add(_user);
            //create chat
            long chatId = DBManager.Instance.CreateChatRoom(chatName);
            //add users to chat
            DBManager.Instance.AddUsersToChatRoom(chatId, chatUsers);
            // refresh view
            _chatRooms = GetChatRooms();
            _view.SetChatListBox(_chatRooms);
        }

        private void LeaveChatRoom(int listId)
        {
            var chatRoomId = _chatRooms[listId].Id;
            DBManager.Instance.LeaveChatRoom(chatRoomId, _user.Id);

            _chatRooms = GetChatRooms();
            _view.SetChatListBox(_chatRooms);
        }

        private void UpdateChatRoom(int listId, string name, List<Model.User> userList)
        {
            userList.Add(_user);
            var chatRoom = _chatRooms[listId];

            List<User> remove = new List<User>();
            List<User> add = new List<User>();
            // podział na dwie listy remove, add

            foreach (var user in userList)
            {
                if (!chatRoom.Participants.Contains(user))
                {
                    add.Add(user);
                }
            }

            foreach (var user in chatRoom.Participants)
            {
                if (!userList.Contains(user))
                {
                    remove.Add(user);
                }
            }

            DBManager.Instance.RemoveUsersFromChatRoom(chatRoom.Id, remove);
            DBManager.Instance.AddUsersToChatRoom(chatRoom.Id, add);

            DBManager.Instance.UpdateChatRoom(chatRoom.Id, name);

            _chatRooms = GetChatRooms();
            _view.SetChatListBox(_chatRooms);
        }
    }
}