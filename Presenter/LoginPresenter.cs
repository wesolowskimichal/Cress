using Cress.Model;
using Cress.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cress.Presenter
{

    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly LoginModel loginModel;
        private readonly Main main;
        public LoginPresenter(ILoginView view, LoginModel model, Main main)
        {
            this.view = view;
            this.loginModel = model;
            this.main = main;
            view.LoginButtonClick += view_Login;
            view.ShowPassword += show_Password;
            view.Register += view_Register;
        }
        private void view_Login()
        {
            string email = view.Email;
            string password = view.Password;

            bool isAuthenticated = loginModel.Authenticate(email, password);

            if (isAuthenticated)
            {
                main.user = DBManager.Instance.GetUser(email, password);
                main.LoggedIn();
            }
            else
            {
                view.LoginErrorLabel.Text = "Wrong email or password!";
            }
        }

        private void view_Register()
        {
            main.Registration();
        }

        private void show_Password()
        {
            if (view.PasswordTextBox.PasswordChar == '*')
            {
                view.PasswordTextBox.PasswordChar = '\0';
                //button_showPass.Text = "*";
            }
            else
            {
                view.PasswordTextBox.PasswordChar = '*';
                //button_showPass.Text = "o";
            }
        }
    }
}
