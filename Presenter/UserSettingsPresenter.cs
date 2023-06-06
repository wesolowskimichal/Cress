using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cress.Model;
using Cress.View.UserSettings;

namespace Cress.Presenter
{
    public class UserSettingsPresenter
    {
        private readonly User _user;
        private readonly UserSettings _view;
        public UserSettingsPresenter(UserSettings view, User user)
        {
            _user = user;
            _view = view;
            //map actions
            view.DeleteUser += DeleteUser;
            view.ChangeUserPicture += ChangeUserPicture;
            view.ChangeUserEmail += ChangeUserEmail;
            view.ChangeUserPassword += ChangeUserPassword;
            //set username and email fields
            _view.username_label_Set(user.Username);
            _view.email_label_Set(user.Email);
            _view.pictureBox_Set(user.ProfilePicture);
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
                _view.create_MessageBox(e.Message, "Error while deleating account");
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
                _view.pictureBox_Set(new_picture);
            }
            catch (Exception e)
            {
                _view.create_MessageBox(e.Message, "Error while changing profile picture");
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
                _view.email_label_Set(new_email);
            }
            catch (Exception e)
            {
                _view.create_MessageBox(e.Message, "Error while changing email picture");
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
                _view.create_MessageBox("New password", "Password changed");
            }
            catch (Exception e)
            {
                _view.create_MessageBox(e.Message, "Error while changing email picture");
            }
        }

    }
}
