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

namespace Cress.Presenter
{
    public class CreateChatRoomPresenter
    {
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

        public CreateChatRoomPresenter(CreateChatRoomView view, User user)
        {
            _user = user;
            _view = view;
            _chatRooms = GetChatRooms();
            _users = GetUsers();

            _view.CreateNewChatRoom += CreateNewChatRoom;
            _view.LeaveChatRoom += LeaveChatRoom;
            _view.UpdateChatRoom += UpdateChatRoom;
            //load chats
            _view.SetChatListBox(_chatRooms);
            _view.SetUserListBox(_users);
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

        private void UpdateChatRoom(int listId, string name)
        {
            var chatRoomId = _chatRooms[listId].Id;
            DBManager.Instance.UpdateChatRoom(chatRoomId, name);

            _chatRooms = GetChatRooms();
            _view.SetChatListBox(_chatRooms);
        }
    }
}
