using Cress.View.UserSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cress.Model.PasswordChecker;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cress.Model
{
    public class ChangeEmailDialogPresenter
    {
        private readonly IChangeEmailDialog view;
        private readonly IUserSettings userSettings;
        private Action LogOut;

        public ChangeEmailDialogPresenter(IChangeEmailDialog view, IUserSettings userSettings, Action logOut)
        {
            this.view = view;
            this.userSettings = userSettings;
            this.view.ChangeEmail += Change_Email;
            LogOut = logOut;
        }

        private void Change_Email()
        {
            if (DBManager.Instance.ExecuteQueryGetCount($"SELECT COUNT(*) FROM users WHERE username = '{view.Email}'") != 0)
            {
                view.ErrorLabel.Text = "User Already Exists!";
                return;
            }
            DBManager.Instance.UpdateEmail(userSettings.EmailLabel.Text, view.Email);
            view.ErrorLabel.Text = "Email Changed, Relogin";
            LogOut();
        }
    }
}
