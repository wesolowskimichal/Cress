using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cress.Model;
using Cress.View.UserSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Cress.Presenter
{
    public class UserSettingsPresenter
    {
        private readonly User _user;
        private readonly IUserSettings _view;
        public UserSettingsPresenter(IUserSettings view, User user)
        {
            _user = user;
            _view = view;
            //map actions
            _view.DeleteUser += DeleteUser;
            _view.ChangeUserPicture += ChangeUserPicture;
            _view.ChangeUserEmail += ChangeUserEmail;
            _view.ChangeUserPassword += ChangeUserPassword;
            _view.ChangePasswordDial += Change_Password_Dial;
            _view.ChangeEmailDial += Change_Email_Dial;
            //set username and email fields
            _view.UsernameLabel.Text = "Hello " + user.Username + "!";
            _view.EmailLabel.Text = "Email: " + user.Username;
            _view.PictureBox.Image = user.ProfilePicture;
        }

        private void Change_Password_Dial(UserSettings userSettings)
        {
            var dialog = new ChangePasswordDialog(userSettings);
            dialog.Show();
        }

        private void Change_Email_Dial(UserSettings userSettings)
        {
            var dialog = new ChangeEmailDialog(userSettings);
            dialog.Show();
        }

        private void DeleteUser()
        {
            try
            {
                //TODO
                //delete from db
            }
            catch (Exception e)
            {
                Environment.Exit(404);
            }
        }

        private void ChangeUserPicture(string fileName)
        {
            Image new_picture = Image.FromFile(fileName);
            try
            {
                //TODO
                //set as new profile picture

                //then
                _view.PictureBox.Image = new_picture;
            }
            catch (Exception e)
            {
                Environment.Exit(404);
            }
        }

        private void ChangeUserEmail(string new_email)
        {
            try
            {
                //TODO
                //check if email already exists in db if no
                //set as new email

                //then
                _view.EmailLabel.Text = new_email;
            }
            catch (Exception e)
            {
                Environment.Exit(404);
            }
        }
        private void ChangeUserPassword(string old_password, string new_password)
        {
            try
            {
                //TODO
                //check if old password matches new or messagebox
                //set as new password

                //then
                MessageBox.Show("password", "Password Changed");
            }
            catch (Exception e)
            {
                Environment.Exit(404);
            }
        }

    }
}