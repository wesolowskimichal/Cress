using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cress.View.UserSettings
{
    public partial class UserSettings : Form, IUserSettings
    {
        #region implementation of IUserSettings
        public System.Windows.Forms.PictureBox PictureBox => pictureBox; 
        public System.Windows.Forms.Label EmailLabel => email_label;
        public System.Windows.Forms.Label UsernameLabel => username_label;

        public event Action ChangePasswordDial;
        public event Action ChangeEmailDial;

        public event Action DeleteUser;
        public event Action<string> ChangeUserPicture;
        #endregion
        public UserSettings()
        {
            InitializeComponent();
        }
        private void delUser_btn_Click(object sender, EventArgs e)
        {
            DeleteUser?.Invoke();
            //TODO
            // wylogowac go w kontrolerze (?)
            // przeniesc go na ekran logowania (?)
        }

        private void chngImg_btn_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "image files (*.png)|*.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                ChangeUserPicture?.Invoke(Path.GetFullPath(filePath));
            }
        }
        private void chngEmail_btn_Click(object sender, EventArgs e)
        {
            //TODO
            // dialog/messagebox co jest tam miejsce na nowego emaila
            ChangeEmailDial?.Invoke();
            
        }

        private void chngPassword_btn_Click(object sender, EventArgs e)
        {
            //TODO
            // dialog co jest tam miejsce na nowe i stare hasło
            ChangePasswordDial?.Invoke();
            
        }
    }
}