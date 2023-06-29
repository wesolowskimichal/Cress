using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cress.Model;
using Cress.View;
using Cress.View.UserSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Cress.Presenter
{
    public class UserSettingsPresenter
    {
        private User _user;
        private IUserSettings _view;
        private ChangeEmailDialogPresenter changeEmailDialogPresenter;
        private ChangePasswordDialogPresenter changePasswordDialogPresenter;
        private Action LogOut;

        public UserSettingsPresenter(IUserSettings view, User user, Action logOut)
        {
            _user = user;
            _view = view;
            LogOut = logOut;
            //map actions
            _view.DeleteUser += DeleteUser;
            _view.ChangeUserPicture += ChangeUserPicture;
            _view.ChangePasswordDial += Change_Password_Dial;
            _view.ChangeEmailDial += Change_Email_Dial;
            //set username and email fields
            _view.UsernameLabel.Text = "Hello " + user.Username + "!";
            _view.EmailLabel.Text = "Email: " + user.Username;
            _view.PictureBox.Image = user.ProfilePicture;
        }

        private void Change_Password_Dial()
        {
            var dialog = new ChangePasswordDialog();
            changePasswordDialogPresenter = new ChangePasswordDialogPresenter(dialog, _view, LogOut);
            dialog.Show();
        }

        private void Change_Email_Dial()
        {
            var dialog = new ChangeEmailDialog();
            changeEmailDialogPresenter = new ChangeEmailDialogPresenter(dialog, _view, LogOut);
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

    }
}