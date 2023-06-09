using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.View
{
    public interface ILoginView
    {
        string Email { get; }
        string Password { get; }
        System.Windows.Forms.TextBox PasswordTextBox { get; }
        System.Windows.Forms.Label LoginErrorLabel { get; }

        event Action LoginButtonClick;
        event Action ShowPassword;
    }
}
