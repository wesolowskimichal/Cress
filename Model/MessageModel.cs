﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.Model
{
    public class Message
    {
        public User Sender { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        // Additional properties and methods as per your requirements
    }
}
