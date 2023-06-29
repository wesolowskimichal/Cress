using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress.View.UserSettings
{
    public partial class ChangePasswordDialog : Form, IChangePasswordDialog
    {
        #region implementation of IChangeDialog
        public System.Windows.Forms.Label ErrorLabel => error_label;
        public String OldPassword => old_pass.Text;
        public String NewPassword => new_pass1.Text;
        public String NewPasswordRetyped => new_pass2.Text;

        public System.Windows.Forms.ProgressBar PassScore => passScore_bar;


        public event Action ChangePassword;
        public event Action PassKeyUp;
        #endregion

        public ChangePasswordDialog()
        {
            InitializeComponent();
        }
        private void chngPass_btn_Click(object sender, EventArgs e)
        {
            ChangePassword?.Invoke();
        }

        private void new_pass1_KeyUp(object sender, KeyEventArgs e)
        {
            PassKeyUp?.Invoke();
        }
    }
}