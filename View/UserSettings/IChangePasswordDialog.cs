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
    }
}
