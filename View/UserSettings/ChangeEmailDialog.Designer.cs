namespace Cress.View.UserSettings
{
    partial class ChangeEmailDialog
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
            this.new_email_in = new System.Windows.Forms.TextBox();
            this.chng_email_btn = new System.Windows.Forms.Button();
            this.error_msg = new System.Windows.Forms.Label();
            this.new_emai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_email_in
            // 
            this.new_email_in.Location = new System.Drawing.Point(119, 43);
            this.new_email_in.Name = "new_email_in";
            this.new_email_in.Size = new System.Drawing.Size(186, 20);
            this.new_email_in.TabIndex = 0;
            // 
            // chng_email_btn
            // 
            this.chng_email_btn.Location = new System.Drawing.Point(148, 99);
            this.chng_email_btn.Name = "chng_email_btn";
            this.chng_email_btn.Size = new System.Drawing.Size(126, 23);
            this.chng_email_btn.TabIndex = 1;
            this.chng_email_btn.Text = "Change email";
            this.chng_email_btn.UseVisualStyleBackColor = true;
            this.chng_email_btn.Click += new System.EventHandler(this.chng_email_btn_Click);
            // 
            // error_msg
            // 
            this.error_msg.AutoSize = true;
            this.error_msg.Location = new System.Drawing.Point(168, 83);
            this.error_msg.Name = "error_msg";
            this.error_msg.Size = new System.Drawing.Size(35, 13);
            this.error_msg.TabIndex = 2;
            this.error_msg.Text = "label1";
            // 
            // new_emai
            // 
            this.new_emai.AutoSize = true;
            this.new_emai.Location = new System.Drawing.Point(30, 46);
            this.new_emai.Name = "new_emai";
            this.new_emai.Size = new System.Drawing.Size(59, 13);
            this.new_emai.TabIndex = 3;
            this.new_emai.Text = "New email:";
            // 
            // ChangeEmailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.new_emai);
            this.Controls.Add(this.error_msg);
            this.Controls.Add(this.chng_email_btn);
            this.Controls.Add(this.new_email_in);
            this.Name = "ChangeEmailDialog";
            this.Text = "ChangeEmailDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_email_in;
        private System.Windows.Forms.Button chng_email_btn;
        private System.Windows.Forms.Label error_msg;
        private System.Windows.Forms.Label new_emai;
    }
}