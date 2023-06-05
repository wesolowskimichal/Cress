namespace Cress.View
{
    partial class LoginViewController
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_showPass = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_showPass
            // 
            this.button_showPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(123)))), ((int)(((byte)(98)))));
            this.button_showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.button_showPass.FlatAppearance.BorderSize = 3;
            this.button_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_showPass.Location = new System.Drawing.Point(796, 352);
            this.button_showPass.Name = "button_showPass";
            this.button_showPass.Size = new System.Drawing.Size(27, 27);
            this.button_showPass.TabIndex = 13;
            this.button_showPass.Text = "O";
            this.button_showPass.UseVisualStyleBackColor = false;
            this.button_showPass.Click += new System.EventHandler(this.button_showPass_Click);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.button_login.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_login.Location = new System.Drawing.Point(627, 388);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(123, 33);
            this.button_login.TabIndex = 11;
            this.button_login.Text = "LogIn";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(123)))), ((int)(((byte)(98)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_email.Location = new System.Drawing.Point(585, 305);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(205, 33);
            this.textBox_email.TabIndex = 10;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(123)))), ((int)(((byte)(98)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_password.Location = new System.Drawing.Point(585, 349);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(205, 33);
            this.textBox_password.TabIndex = 9;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.label_password.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.Location = new System.Drawing.Point(465, 349);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(114, 25);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "Password";
            // 
            // label_email
            // 
            this.label_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.label_email.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_email.Location = new System.Drawing.Point(465, 307);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(114, 25);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "Email";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cress.Properties.Resources.background_login;
            this.Controls.Add(this.button_showPass);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Name = "LoginViewController";
            this.Size = new System.Drawing.Size(1366, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_showPass;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_email;
    }
}
