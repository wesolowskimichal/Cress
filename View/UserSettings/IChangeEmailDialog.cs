using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.View.UserSettings
{
    public interface IChangeEmailDialog
    {
        System.Windows.Forms.Label ErrorLabel { get; }
        String Email { get; }

        event Action ChangeEmail;
    }
}
