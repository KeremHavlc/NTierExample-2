﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public class Token
    {
        public string Accesstoken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
