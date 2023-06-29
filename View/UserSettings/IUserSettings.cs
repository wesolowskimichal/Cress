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
        event Action ChangePasswordDial;
        event Action ChangeEmailDial;
        event Action<string> ChangeUserPicture;
    }
}
