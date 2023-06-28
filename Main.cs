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
        public Main()
        {
            InitializeComponent();
            chatRoomView1.Visible = false;
            registerView1.Visible = false;
            createChatRoomView1.Visible = false;
            var view = loginViewController1;
            var model = new Model.LoginModel();
            var presenter = new Presenter.LoginPresenter(view, model, this);
            var reg_model = new Model.RegisterModel();
            var reg_presenter = new Presenter.RegisterPresenter(registerView1, reg_model, this);
        }

        public void LoggedIn()
        {
            var presenter = new Presenter.ChatRoomPresenter(chatRoomView1, user, ShowManage, LogOut);
            var pr = new Presenter.CreateChatRoomPresenter(createChatRoomView1, user, ShowManage);
            chatRoomView1.Visible = true;
            registerView1.Visible = false;
            loginViewController1.Visible = false;
        }

        public void LogOut()
        {
            user = null;
            loginViewController1.Visible = true;
            chatRoomView1.Visible = false;
            registerView1.Visible = false;
            createChatRoomView1.Visible = false;
        }

        public void Registration()
        {
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
