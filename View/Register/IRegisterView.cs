using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.View.Register
{
    public interface IRegisterView
    {
        string Email { get; }
        string Password { get; }
        System.Windows.Forms.TextBox PasswordTextBox { get; }
        System.Windows.Forms.Label RegisterErrorLabel { get; }
        System.Windows.Forms.ProgressBar PassScore { get; }

        event Action RegisterButtonClick;
        event Action ShowPassword;
        event Action CheckPassScore;
    }
}
