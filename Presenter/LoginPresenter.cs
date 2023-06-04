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
        public LoginPresenter(ILoginView view, LoginModel model)
        {
            this.view = view;
            this.loginModel = model;
            view.LoginButtonClick += view_Login;
            view.ShowPassword += show_Password;
        }
        private void view_Login()
        {
            string email = view.Email;
            string password = view.Password;

            bool isAuthenticated = loginModel.Authenticate(email, password);

            if (isAuthenticated)
            {
            }
            else
            {
            }
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
