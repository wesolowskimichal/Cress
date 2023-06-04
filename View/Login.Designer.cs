namespace Cress.View
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_passw = new System.Windows.Forms.Label();
            this.button_showPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.label_email.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_email.Location = new System.Drawing.Point(443, 265);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(114, 25);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Email";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.label_password.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.Location = new System.Drawing.Point(443, 307);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(114, 25);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(123)))), ((int)(((byte)(98)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_password.Location = new System.Drawing.Point(563, 307);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(205, 33);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(123)))), ((int)(((byte)(98)))));
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox_email.Location = new System.Drawing.Point(563, 263);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(205, 33);
            this.textBox_email.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.button_login.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_login.Location = new System.Drawing.Point(605, 346);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(123, 33);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "LogIn";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_passw
            // 
            this.label_passw.AutoSize = true;
            this.label_passw.Location = new System.Drawing.Point(829, 83);
            this.label_passw.Name = "label_passw";
            this.label_passw.Size = new System.Drawing.Size(0, 13);
            this.label_passw.TabIndex = 5;
            // 
            // button_showPass
            // 
            this.button_showPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(123)))), ((int)(((byte)(98)))));
            this.button_showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(132)))), ((int)(((byte)(157)))));
            this.button_showPass.FlatAppearance.BorderSize = 3;
            this.button_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showPass.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_showPass.Location = new System.Drawing.Point(774, 310);
            this.button_showPass.Name = "button_showPass";
            this.button_showPass.Size = new System.Drawing.Size(27, 27);
            this.button_showPass.TabIndex = 6;
            this.button_showPass.Text = "O";
            this.button_showPass.UseVisualStyleBackColor = false;
            this.button_showPass.Click += new System.EventHandler(this.button_showPass_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cress.Properties.Resources.background_login;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button_showPass);
            this.Controls.Add(this.label_passw);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_passw;
        private System.Windows.Forms.Button button_showPass;
    }
}