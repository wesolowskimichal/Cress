namespace Cress.View.UserSettings
{
    partial class UserSettings
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
            this.username_label = new System.Windows.Forms.Label();
            this.chngImg_btn = new System.Windows.Forms.Button();
            this.chngEmail_btn = new System.Windows.Forms.Button();
            this.chngPassword_btn = new System.Windows.Forms.Button();
            this.delUser_btn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.username_label.Location = new System.Drawing.Point(261, 9);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(226, 31);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Hello {Username}";
            // 
            // chngImg_btn
            // 
            this.chngImg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chngImg_btn.Location = new System.Drawing.Point(56, 336);
            this.chngImg_btn.Name = "chngImg_btn";
            this.chngImg_btn.Size = new System.Drawing.Size(250, 51);
            this.chngImg_btn.TabIndex = 1;
            this.chngImg_btn.Text = "Change profile picture";
            this.chngImg_btn.UseVisualStyleBackColor = true;
            this.chngImg_btn.Click += new System.EventHandler(this.chngImg_btn_Click);
            // 
            // chngEmail_btn
            // 
            this.chngEmail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chngEmail_btn.Location = new System.Drawing.Point(585, 58);
            this.chngEmail_btn.Name = "chngEmail_btn";
            this.chngEmail_btn.Size = new System.Drawing.Size(187, 47);
            this.chngEmail_btn.TabIndex = 2;
            this.chngEmail_btn.Text = "Change email";
            this.chngEmail_btn.UseVisualStyleBackColor = true;
            this.chngEmail_btn.Click += new System.EventHandler(this.chngEmail_btn_Click);
            // 
            // chngPassword_btn
            // 
            this.chngPassword_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chngPassword_btn.Location = new System.Drawing.Point(585, 151);
            this.chngPassword_btn.Name = "chngPassword_btn";
            this.chngPassword_btn.Size = new System.Drawing.Size(187, 47);
            this.chngPassword_btn.TabIndex = 3;
            this.chngPassword_btn.Text = "Change password";
            this.chngPassword_btn.UseVisualStyleBackColor = true;
            this.chngPassword_btn.Click += new System.EventHandler(this.chngPassword_btn_Click);
            // 
            // delUser_btn
            // 
            this.delUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delUser_btn.Location = new System.Drawing.Point(585, 261);
            this.delUser_btn.Name = "delUser_btn";
            this.delUser_btn.Size = new System.Drawing.Size(187, 47);
            this.delUser_btn.TabIndex = 4;
            this.delUser_btn.Text = "Delete account";
            this.delUser_btn.UseVisualStyleBackColor = true;
            this.delUser_btn.Click += new System.EventHandler(this.delUser_btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(56, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 250);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username_lbl.Location = new System.Drawing.Point(312, 69);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(113, 25);
            this.username_lbl.TabIndex = 6;
            this.username_lbl.Text = "Username: ";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email_label.Location = new System.Drawing.Point(312, 104);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(71, 25);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Email: ";
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.delUser_btn);
            this.Controls.Add(this.chngPassword_btn);
            this.Controls.Add(this.chngEmail_btn);
            this.Controls.Add(this.chngImg_btn);
            this.Controls.Add(this.username_label);
            this.Name = "UserSettings";
            this.Text = "UserSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button chngImg_btn;
        private System.Windows.Forms.Button chngEmail_btn;
        private System.Windows.Forms.Button chngPassword_btn;
        private System.Windows.Forms.Button delUser_btn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label email_label;
    }
}