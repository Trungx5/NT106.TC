﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class User
    {
        public string Name { get; set; }
        public TcpClient Client { get; set; }

        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }
    }
}
