namespace Cress.View
{
    partial class CreateChatRoomView
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
            this.UserListBox = new System.Windows.Forms.CheckedListBox();
            this.CreateChtRm_Btn = new System.Windows.Forms.Button();
            this.ChatListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newChatName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserListBox
            // 
            this.UserListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(277, 0);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(423, 268);
            this.UserListBox.TabIndex = 0;
            // 
            // CreateChtRm_Btn
            // 
            this.CreateChtRm_Btn.Location = new System.Drawing.Point(385, 313);
            this.CreateChtRm_Btn.Name = "CreateChtRm_Btn";
            this.CreateChtRm_Btn.Size = new System.Drawing.Size(227, 23);
            this.CreateChtRm_Btn.TabIndex = 1;
            this.CreateChtRm_Btn.Text = "Create new chat room";
            this.CreateChtRm_Btn.UseVisualStyleBackColor = true;
            this.CreateChtRm_Btn.Click += new System.EventHandler(this.CreateChtRm_Btn_Click);
            // 
            // ChatListBox
            // 
            this.ChatListBox.FormattingEnabled = true;
            this.ChatListBox.Location = new System.Drawing.Point(0, 0);
            this.ChatListBox.Name = "ChatListBox";
            this.ChatListBox.Size = new System.Drawing.Size(277, 472);
            this.ChatListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chat room name";
            // 
            // newChatName
            // 
            this.newChatName.Location = new System.Drawing.Point(385, 272);
            this.newChatName.Name = "newChatName";
            this.newChatName.Size = new System.Drawing.Size(227, 20);
            this.newChatName.TabIndex = 4;
            // 
            // NewChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newChatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChatListBox);
            this.Controls.Add(this.CreateChtRm_Btn);
            this.Controls.Add(this.UserListBox);
            this.Name = "NewChatRoom";
            this.Size = new System.Drawing.Size(700, 475);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox UserListBox;
        private System.Windows.Forms.Button CreateChtRm_Btn;
        private System.Windows.Forms.ListBox ChatListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newChatName;
    }
}
