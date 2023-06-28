using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            var view = loginViewController1;
            var model = new Model.LoginModel();
            var presenter = new Presenter.LoginPresenter(view, model, this);
        }

        public void LoggedIn()
        {
            var presenter = new Presenter.ChatRoomPresenter(chatRoomView1, user);
            chatRoomView1.Visible = true;
            registerView1.Visible = false;
            loginViewController1.Visible = false;
        }

        public void Registration()
        {
            var model = new Model.RegisterModel();
            var presenter = new Presenter.RegisterPresenter(registerView1, model, this);
            registerView1.Visible = true;
        }
    }
}
