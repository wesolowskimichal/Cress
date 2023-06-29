using Cress.Model;
using Cress.View.UserSettings;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.Presenter
{
    public class ChangePasswordDialogPresenter
    {
        private readonly IChangePasswordDialog view;
        private readonly IUserSettings userSettings;
        private Action LogOut;

        public ChangePasswordDialogPresenter(IChangePasswordDialog view, IUserSettings userSettings, Action logOut)
        {
            this.view = view;
            this.userSettings = userSettings;
            this.view.ChangePassword += Change_Password;
            this.view.PassKeyUp += check_PassScore;
            LogOut = logOut;
        }

        private void Change_Password()
        {
            //to do: substring email
            string email = userSettings.EmailLabel.Text.Substring(7);
            string password = view.OldPassword;
            string new_pasword = view.NewPassword;
            string new_password_retyped = view.NewPasswordRetyped;

            if(!DBManager.Instance.CheckExistance(email, password))
            {
                view.ErrorLabel.Text = "Wrong Password!";
                return;
            }

            if(new_pasword != new_password_retyped)
            {
                view.ErrorLabel.Text = "New Password Does Not Match!";
                return;
            }

            if(PasswordChecker.CheckStrength(new_pasword) < 3)
            {
                view.ErrorLabel.Text = "New Password Too Weak!";
                return;
            }

            DBManager.Instance.UpdatePassword(email, new_pasword);
            LogOut();
        }

        private void check_PassScore()
        {
            view.PassScore.Value = PasswordChecker.CheckStrength(view.NewPassword);
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
                    view.PassScore.ForeColor = Color.LawnGreen;
                    break;
                case 5:
                    view.PassScore.ForeColor = Color.Green;
                    break;
                case 6:
                    view.PassScore.ForeColor = Color.DarkGreen;
                    break;
            }
        }
    }
}
