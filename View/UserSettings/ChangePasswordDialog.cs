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
    public partial class ChangePasswordDialog : Form
    {
        private readonly UserSettings _form;
        public ChangePasswordDialog(UserSettings form)
        {
            InitializeComponent();
            _form = form;
        }
        private void chngPass_btn_Click(object sender, EventArgs e)
        {
            //TODO
            //regex do walidacji hasla
            // if regex zly -> error_msg.Text = "error bo costam";
            if (new_pass1.Text == new_pass2.Text)
            {
                _form.set_new_password(old_pass.Text, new_pass2.Text);
                this.Close();
            }
            error_label.Text = "New passwords doesnt match";
        }
    }
}
