using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.View.UserSettings
{
    public interface IUserSettings
    {
        System.Windows.Forms.PictureBox PictureBox { get; }
        System.Windows.Forms.Label EmailLabel { get; }
        System.Windows.Forms.Label UsernameLabel { get; }

        event Action DeleteUser;
        event Action<UserSettings> ChangePasswordDial;
        event Action<UserSettings> ChangeEmailDial;
        event Action<string, string> ChangeUserPassword;
        event Action<string> ChangeUserEmail;
        event Action<string> ChangeUserPicture;
    }
}
