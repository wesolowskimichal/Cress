using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.Model
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string Email { get; set; }
        public Image ProfilePicture { get; set; }
        private List<ChatRoom> ChatRooms { get; set; }


        public override string ToString()
        {
            return Username;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is User))
            {
                return false;
            }

            return (this.Id == ((User)obj).Id);
        }
    }
}
