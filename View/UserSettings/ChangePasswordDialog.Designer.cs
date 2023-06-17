namespace Cress.View.UserSettings
{
    partial class ChangePasswordDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chngPass_btn = new System.Windows.Forms.Button();
            this.old_pass = new System.Windows.Forms.TextBox();
            this.new_pass2 = new System.Windows.Forms.TextBox();
            this.new_pass1 = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat new password";
            // 
            // chngPass_btn
            // 
            this.chngPass_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chngPass_btn.Location = new System.Drawing.Point(110, 225);
            this.chngPass_btn.Name = "chngPass_btn";
            this.chngPass_btn.Size = new System.Drawing.Size(134, 23);
            this.chngPass_btn.TabIndex = 3;
            this.chngPass_btn.Text = "Change password";
            this.chngPass_btn.UseVisualStyleBackColor = true;
            this.chngPass_btn.Click += new System.EventHandler(this.chngPass_btn_Click);
            // 
            // old_pass
            // 
            this.old_pass.Location = new System.Drawing.Point(161, 54);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(184, 20);
            this.old_pass.TabIndex = 4;
            // 
            // new_pass2
            // 
            this.new_pass2.Location = new System.Drawing.Point(161, 123);
            this.new_pass2.Name = "new_pass2";
            this.new_pass2.Size = new System.Drawing.Size(184, 20);
            this.new_pass2.TabIndex = 5;
            // 
            // new_pass1
            // 
            this.new_pass1.Location = new System.Drawing.Point(161, 88);
            this.new_pass1.Name = "new_pass1";
            this.new_pass1.Size = new System.Drawing.Size(184, 20);
            this.new_pass1.TabIndex = 6;
            // 
            // error_label
            // 
            this.error_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(142, 185);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(54, 13);
            this.error_label.TabIndex = 7;
            this.error_label.Text = "Error label";
            // 
            // ChangePasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.new_pass1);
            this.Controls.Add(this.new_pass2);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.chngPass_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordDialog";
            this.Text = "ChangePasswordDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chngPass_btn;
        private System.Windows.Forms.TextBox old_pass;
        private System.Windows.Forms.TextBox new_pass2;
        private System.Windows.Forms.TextBox new_pass1;
        private System.Windows.Forms.Label error_label;
    }
}