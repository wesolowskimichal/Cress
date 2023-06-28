using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress.View.Register
{
    public partial class RegisterView : UserControl, IRegisterView
    {

        #region implementation of IRegisterView

        public string Email => textBox_email.Text;
        public string Password => textBox_password.Text;

        public System.Windows.Forms.TextBox PasswordTextBox => textBox_password;
        public System.Windows.Forms.Label RegisterErrorLabel => label_logError;
        public System.Windows.Forms.ProgressBar PassScore => passScore_bar;

        public event Action RegisterButtonClick;
        public event Action ShowPassword;
        public event Action CheckPassScore;
        public event Action LogOut;
        #endregion
        public RegisterView()
        {
            InitializeComponent();
        }

        private void button_showPass_Click(object sender, EventArgs e)
        {
            ShowPassword?.Invoke();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            RegisterButtonClick?.Invoke();
        }

        private void textBox_password_KeyUp(object sender, KeyEventArgs e)
        {
            CheckPassScore?.Invoke();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            LogOut?.Invoke();
        }
    }
}
