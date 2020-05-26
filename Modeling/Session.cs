﻿using System.Collections.Generic;

namespace Modeling
{
    public class Session
    {
        public string Login { get; set; }

        public List<Letter> Letters { get; set; }

        public Session()
        {

        }

        public Session(string login)
        {
            Login = login;
        }
    }
}
