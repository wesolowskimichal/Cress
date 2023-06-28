using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress.View.UserSettings
{
    public partial class ChangeEmailDialog : Form, IChangeEmailDialog
    {
        #region implementation of IChangeEmailDialog
        public System.Windows.Forms.Label ErrorLabel => error_msg;
        public String Email => new_email_in.Text;

        public event Action ChangeEmail;
        #endregion

        public ChangeEmailDialog()
        {
            InitializeComponent();
        }

        private void chng_email_btn_Click(object sender, EventArgs e)
        {
            ChangeEmail?.Invoke();
        }
    }
}