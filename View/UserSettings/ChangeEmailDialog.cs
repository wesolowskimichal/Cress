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
    public partial class ChangeEmailDialog : Form
    {
        private readonly UserSettings _form;
        public ChangeEmailDialog(UserSettings form)
        {
            InitializeComponent();
            error_msg.Text = "";
            _form = form;
        }

        private void chng_email_btn_Click(object sender, EventArgs e)
        {
            //TODO
            //regex do walidacji emaila
            // if regex zly -> error_msg.Text = "error bo costam";
            _form.set_new_email(new_email_in.Text);
            this.Close();
        }
    }
}
