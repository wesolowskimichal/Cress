namespace Cress
{
    partial class Main
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.loginViewController1 = new Cress.View.LoginViewController();
            this.chatRoomView1 = new Cress.View.ChatRoom.ChatRoomView();
            this.SuspendLayout();
            // 
            // loginViewController1
            // 
            this.loginViewController1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginViewController1.BackgroundImage")));
            this.loginViewController1.Location = new System.Drawing.Point(0, 0);
            this.loginViewController1.Name = "loginViewController1";
            this.loginViewController1.Size = new System.Drawing.Size(1366, 768);
            this.loginViewController1.TabIndex = 0;
            // 
            // chatRoomView1
            // 
            this.chatRoomView1.AutoScroll = true;
            this.chatRoomView1.AutoSize = true;
            this.chatRoomView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chatRoomView1.Location = new System.Drawing.Point(354, 104);
            this.chatRoomView1.Name = "chatRoomView1";
            this.chatRoomView1.Size = new System.Drawing.Size(700, 465);
            this.chatRoomView1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.chatRoomView1);
            this.Controls.Add(this.loginViewController1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private View.LoginViewController loginViewController1;
        private View.ChatRoom.ChatRoomView chatRoomView1;
    }
}

