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
        event Action<int, string> SendNewMessage;
        event Action<long> LoadChat;
    }
}
