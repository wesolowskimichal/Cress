using Cress.Model;
using Cress.View.ChatRoom;
using Cress.View.UserSettings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Cress.Presenter
{
    public class ChatRoomPresenter
    {
        private UserSettingsPresenter userSettingsPresenter;
        private View.UserSettings.UserSettings userSettings;
        private Action showManage;
        private Action logOut;
        public readonly User _user;
        private readonly IChatRoomView _view;
        private List<ChatRoom> _chatRooms;
        private bool _isRunning;
        private Thread _thread;

        private List<ChatRoom> GetChatRooms()
        {
            _chatRooms = DBManager.Instance.GetChatRoomsByUserID(_user.Id);
            return _chatRooms;
        }

        public ChatRoomPresenter(IChatRoomView view, User user, Action showManage, Action logOut)
        {
            userSettings = new UserSettings();
            userSettings.Visible = false;
            this.showManage = showManage;
            this.logOut = logOut;
            _user = user;
            _view = view;
            _view.LoadChat += LoadChat;
            _view.SendNewMessage += SendNewMessage;
            _view.ManageClick += Manage_Click;
            _view.UserSettings += User_Settings;
            _view.LogOut += Log_Out;

            _chatRooms = GetChatRooms();

            foreach (ChatRoom chatRoom in _chatRooms)
            {
                _view.ChatRoom_List.Items.Add(chatRoom);
            }

            // Start a background thread to continuously check for new messages
            _isRunning = true;
            _thread = new Thread(CheckForNewMessages);
            _thread.Start();
        }

        private void Log_Out()
        {
            logOut();
        }

        private void User_Settings()
        {
            userSettings = new UserSettings();
            userSettingsPresenter = new Presenter.UserSettingsPresenter(userSettings, _user, logOut);
            userSettings.Visible = true;
        }
        private void Manage_Click()
        {
            _chatRooms = GetChatRooms();
            showManage();
        }

        private void LoadChat(ChatRoom chatRoom)
        {
            if (chatRoom == null)
                return;
            try
            {
                _view.Chat_Panel.Controls.Clear();
                _view.Chat_Panel.Controls.Add(new Label { Text = "                                                                        ", AutoSize = true, Visible = true });

                foreach (Model.Message message in chatRoom.Messages)
                {
                    if (message.Sender.Id == _user.Id)
                    {
                        _view.Chat_Panel.Controls.Add(new Label { Text = $"{message.Content}", BackColor = Color.FromArgb(204, 255, 255), AutoSize = true, Anchor = AnchorStyles.Right, MaximumSize = new Size { Width = _view.Chat_Panel.Width } }) ;
                    }
                    else
                    {
                        _view.Chat_Panel.Controls.Add(new Label { Text = $"{message.Sender.Username}", AutoSize = true });
                        _view.Chat_Panel.Controls.Add(new Label { Text = $"{message.Content}", BackColor = Color.FromArgb(224, 224, 224), AutoSize = true, MaximumSize = new Size { Width = _view.Chat_Panel.Width } });
                    }

                    //_view.Chat_Panel.ScrollControlIntoView(_view.Chat_Panel.Controls[_view.Chat_Panel.Controls.Count - 1]);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
        }

        private void LoadNewMessages(ChatRoom chatRoom, List<Model.Message> newMessages) {
            if (chatRoom == null)
                return;
            foreach (Model.Message message in newMessages)
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

                //_view.Chat_Panel.ScrollControlIntoView(_view.Chat_Panel.Controls[_view.Chat_Panel.Controls.Count - 1]);
            }
            chatRoom.Messages.AddRange(newMessages);
        }

        private void SendNewMessage(ChatRoom chatRoom, string newMessage)
        {
            try
            {
                var newMsg = new Model.Message { Content = newMessage, Timestamp = DateTime.Now, Sender = _user };
                DBManager.Instance.SendMessage(chatRoom, _user, newMessage);
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
        }

        private void CheckForNewMessages()
        {
            while (_isRunning)
            {
                _view.Invoke(new Action(() =>
                {
                    if (_view.ChatRoom_List.SelectedIndex != -1)
                    {
                        ChatRoom chatRoom = _view.ChatRoom_List.SelectedItem as ChatRoom;
                        List<Model.Message> newMessages = DBManager.Instance.GetNewMessages(_user.Id, chatRoom.Id);
                        LoadNewMessages(chatRoom, newMessages);
                    }
                }));
                Thread.Sleep(500);
            }
        }
    }
}