using Cress.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress
{
    public partial class Main : Form
    {
        public Model.User user;
        private Presenter.ChatRoomPresenter chatRoomPresenter;
        private Presenter.CreateChatRoomPresenter createChatRoomPresenter;
        private Presenter.LoginPresenter loginPresenter;
        private Presenter.RegisterPresenter registerPresenter;

        public Main()
        {
            InitializeComponent();
            chatRoomView1.Visible = false;
            registerView1.Visible = false;
            createChatRoomView1.Visible = false;
            var view = loginViewController1;
            var model = new Model.LoginModel();
            loginPresenter = new Presenter.LoginPresenter(view, model, this);
        }

        public void LoggedIn()
        {
            if (chatRoomPresenter == null)
            {
                chatRoomPresenter = new Presenter.ChatRoomPresenter(chatRoomView1, user, ShowManage, LogOut);
            }

            if (createChatRoomPresenter == null)
            {
                createChatRoomPresenter = new Presenter.CreateChatRoomPresenter(createChatRoomView1, user, ShowManage);
            }
            chatRoomView1.Visible = true;
            registerView1.Visible = false;
            loginViewController1.Visible = false;
        }

        public void LogOut()
        {
            user = null;
            chatRoomPresenter = null;
            createChatRoomPresenter = null;
            loginViewController1.Visible = true;
            chatRoomView1.Visible = false;
            registerView1.Visible = false;
            createChatRoomView1.Visible = false;

            chatRoomView1.Clear();
        }

        public void Registration()
        {
            if(registerPresenter == null)
            {
                registerPresenter = new Presenter.RegisterPresenter(registerView1, new Model.RegisterModel(), this);
            }
            registerView1.Visible = true;
        }

        public void ShowManage()
        {
            if (chatRoomView1.Visible)
            {
                chatRoomView1.Visible = false;
                createChatRoomView1.Visible = true;
            }
            else
            {
                chatRoomView1.Visible = true;
                createChatRoomView1.Visible = false;
            }
        }
    }
}
