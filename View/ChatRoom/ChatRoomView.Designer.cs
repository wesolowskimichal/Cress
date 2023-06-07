namespace Cress.View.ChatRoom
{
    partial class ChatRoomView
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
            this.new_message_In = new System.Windows.Forms.TextBox();
            this.send_Btn = new System.Windows.Forms.Button();
            this.chat_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.chatRoom_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // new_message_In
            // 
            this.new_message_In.Location = new System.Drawing.Point(269, 440);
            this.new_message_In.Name = "new_message_In";
            this.new_message_In.Size = new System.Drawing.Size(347, 20);
            this.new_message_In.TabIndex = 2;
            // 
            // send_Btn
            // 
            this.send_Btn.Location = new System.Drawing.Point(622, 439);
            this.send_Btn.Name = "send_Btn";
            this.send_Btn.Size = new System.Drawing.Size(75, 23);
            this.send_Btn.TabIndex = 3;
            this.send_Btn.Text = "Send";
            this.send_Btn.UseVisualStyleBackColor = true;
            this.send_Btn.Click += new System.EventHandler(this.send_Btn_Click);
            // 
            // chat_Panel
            // 
            this.chat_Panel.AutoScroll = true;
            this.chat_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chat_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chat_Panel.Location = new System.Drawing.Point(269, 40);
            this.chat_Panel.Name = "chat_Panel";
            this.chat_Panel.Size = new System.Drawing.Size(428, 393);
            this.chat_Panel.TabIndex = 4;
            this.chat_Panel.WrapContents = false;
            // 
            // chatRoom_List
            // 
            this.chatRoom_List.FormattingEnabled = true;
            this.chatRoom_List.Location = new System.Drawing.Point(3, 40);
            this.chatRoom_List.Name = "chatRoom_List";
            this.chatRoom_List.Size = new System.Drawing.Size(238, 420);
            this.chatRoom_List.TabIndex = 5;
            this.chatRoom_List.SelectedIndexChanged += new System.EventHandler(this.chatRoom_List_SelectedIndexChanged);
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.chatRoom_List);
            this.Controls.Add(this.chat_Panel);
            this.Controls.Add(this.send_Btn);
            this.Controls.Add(this.new_message_In);
            this.Name = "ChatRoom";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox new_message_In;
        private System.Windows.Forms.Button send_Btn;
        private System.Windows.Forms.FlowLayoutPanel chat_Panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox chatRoom_List;
    }
}
