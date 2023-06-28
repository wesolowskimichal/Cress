using Cress.Model;
using Cress.View;
using Cress.View.Register;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Cress.Presenter
{
    public class RegisterPresenter
    {
        private readonly IRegisterView view;
        private readonly RegisterModel registerModel;
        private readonly Main main;
        public RegisterPresenter(IRegisterView view, RegisterModel model, Main main)
        {
            this.view = view;
            this.registerModel = model;
            this.main = main;
            view.RegisterButtonClick += view_Register;
            view.ShowPassword += show_Password;
            view.CheckPassScore += check_PassScore;
            view.LogOut += Log_Out;
        }

        private void Log_Out()
        {
            main.LogOut();
        }

        private void view_Register()
        {
            string email = view.Email;
            string password = view.Password;

            RegisterModel.RegStatus regStatus = registerModel.Authenticate(email, password);

            switch (regStatus)
            {
                case RegisterModel.RegStatus.W_USERNAME:
                    view.RegisterErrorLabel.Text = "User already exists!";
                    break;
                case RegisterModel.RegStatus.ERROR:
                    view.RegisterErrorLabel.Text = "Wrong syntax!";
                    break;
            }
            if (regStatus == RegisterModel.RegStatus.SUCCESS)
            {
                if (RegisterModel.CheckStrength(view.Password) < 3)
                {
                    view.RegisterErrorLabel.Text = "Password too weak!";
                    return;
                }
                DBManager.Instance.AddUser(email, password);
                main.user = DBManager.Instance.GetUser(email, password);
                main.LoggedIn();
            }
        }

        private void check_PassScore()
        {
            view.PassScore.Value = RegisterModel.CheckStrength(view.PasswordTextBox.Text);
            switch (view.PassScore.Value)
            {
                case 0:
                    view.PassScore.ForeColor = Color.DarkRed;
                    break;
                case 1:
                    view.PassScore.ForeColor = Color.Red;
                    break;
                case 2:
                    view.PassScore.ForeColor = Color.OrangeRed;
                    break;
                case 3:
                    view.PassScore.ForeColor = Color.Orange;
                    break;
                case 4:
                    view.PassScore.ForeColor = Color.LawnGreen ;
                    break;
                case 5:
                    view.PassScore.ForeColor = Color.Green;
                    break;
                case 6:
                    view.PassScore.ForeColor = Color.DarkGreen;
                    break;
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
