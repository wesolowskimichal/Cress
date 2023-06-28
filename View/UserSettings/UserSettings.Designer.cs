namespace Cress.View.UserSettings
{
    partial class UserSettings
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
            this.email_label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.delUser_btn = new System.Windows.Forms.Button();
            this.chngPassword_btn = new System.Windows.Forms.Button();
            this.chngEmail_btn = new System.Windows.Forms.Button();
            this.chngImg_btn = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email_label.Location = new System.Drawing.Point(306, 126);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(71, 25);
            this.email_label.TabIndex = 15;
            this.email_label.Text = "Email: ";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(50, 104);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 250);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // delUser_btn
            // 
            this.delUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delUser_btn.Location = new System.Drawing.Point(579, 307);
            this.delUser_btn.Name = "delUser_btn";
            this.delUser_btn.Size = new System.Drawing.Size(187, 47);
            this.delUser_btn.TabIndex = 12;
            this.delUser_btn.Text = "Delete account";
            this.delUser_btn.UseVisualStyleBackColor = true;
            this.delUser_btn.Click += new System.EventHandler(this.delUser_btn_Click);
            // 
            // chngPassword_btn
            // 
            this.chngPassword_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chngPassword_btn.Location = new System.Drawing.Point(579, 197);
            this.chngPassword_btn.Name = "chngPassword_btn";
            this.chngPassword_btn.Size = new System.Drawing.Size(187, 47);
            this.chngPassword_btn.TabIndex = 11;
            this.chngPassword_btn.Text = "Change password";
            this.chngPassword_btn.UseVisualStyleBackColor = true;
            this.chngPassword_btn.Click += new System.EventHandler(this.chngPassword_btn_Click);
            // 
            // chngEmail_btn
            // 
            this.chngEmail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chngEmail_btn.Location = new System.Drawing.Point(579, 104);
            this.chngEmail_btn.Name = "chngEmail_btn";
            this.chngEmail_btn.Size = new System.Drawing.Size(187, 47);
            this.chngEmail_btn.TabIndex = 10;
            this.chngEmail_btn.Text = "Change email";
            this.chngEmail_btn.UseVisualStyleBackColor = true;
            this.chngEmail_btn.Click += new System.EventHandler(this.chngEmail_btn_Click);
            // 
            // chngImg_btn
            // 
            this.chngImg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chngImg_btn.Location = new System.Drawing.Point(50, 382);
            this.chngImg_btn.Name = "chngImg_btn";
            this.chngImg_btn.Size = new System.Drawing.Size(250, 51);
            this.chngImg_btn.TabIndex = 9;
            this.chngImg_btn.Text = "Change profile picture";
            this.chngImg_btn.UseVisualStyleBackColor = true;
            this.chngImg_btn.Click += new System.EventHandler(this.chngImg_btn_Click);
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.username_label.Location = new System.Drawing.Point(255, 55);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(226, 31);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "Hello {Username}";
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.delUser_btn);
            this.Controls.Add(this.chngPassword_btn);
            this.Controls.Add(this.chngEmail_btn);
            this.Controls.Add(this.chngImg_btn);
            this.Controls.Add(this.username_label);
            this.Name = "UserSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button delUser_btn;
        private System.Windows.Forms.Button chngPassword_btn;
        private System.Windows.Forms.Button chngEmail_btn;
        private System.Windows.Forms.Button chngImg_btn;
        private System.Windows.Forms.Label username_label;
    }
}