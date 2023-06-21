using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.Model
{
    public class ChatRoom
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<User> Participants { get; set; }
        public List<Message> Messages { get; set; }

        public ChatRoom()
        {
            Participants = new List<User>();
            Messages = new List<Message>();
        }

        public override string ToString()
        {
            return Name;
        }
        // Additional properties and methods as per your requirements
    }
}
