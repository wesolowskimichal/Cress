using Cress.Model;
using Cress.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cress.View
{
    public partial class Login : Form, ILoginView
    {
        #region implementation of ILoginView
        public string Email => textBox_email.Text;

        public string Password => textBox_password.Text;

        public System.Windows.Forms.TextBox PasswordTextBox => textBox_password;

        public event Action LoginButtonClick;
        public event Action ShowPassword;

        #endregion
        public Login()
        {
            InitializeComponent();
        }

        private void button_showPass_Click(object sender, EventArgs e)
        {
            ShowPassword?.Invoke();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            LoginButtonClick?.Invoke();
        }
    }
}
