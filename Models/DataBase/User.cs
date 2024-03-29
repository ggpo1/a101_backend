﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using a101_backend.Models.Enums;

namespace a101_backend.Models.DataBase
{
    public class User
    {
        public User(int userID, string userName, string passwordHash, UserRoles role)
        {
            UserID = userID;
            UserName = userName;
            PasswordHash = passwordHash;
            Role = role;
        }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public UserRoles Role { get; set; }
    }
}
