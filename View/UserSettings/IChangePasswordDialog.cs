using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.View.UserSettings
{
    public interface IChangePasswordDialog
    {
        System.Windows.Forms.Label ErrorLabel { get; }
        String OldPassword { get; }
        String NewPassword { get; }
        String NewPasswordRetyped { get; }
        System.Windows.Forms.ProgressBar PassScore { get; }

        event Action ChangePassword;
        event Action PassKeyUp;

    }
}
