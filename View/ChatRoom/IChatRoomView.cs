using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.View.ChatRoom
{
    public interface IChatRoomView
    {
        System.Windows.Forms.ListBox ChatRoom_List { get; }
        System.Windows.Forms.FlowLayoutPanel Chat_Panel { get; }
        int CurrentChatRoomIdx { get; }

        event Action<Model.ChatRoom, string> SendNewMessage;
        event Action<Model.ChatRoom> LoadChat;
        event Action ManageClick;
        event Action UserSettings;

        void Invoke(Action action);
    }
}
