﻿using LibrarySystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Service
{
    public interface IUserService
    {
        void CreateUser(User user);
        void DeleteUser(int id);
        void UpdateUser(int id, User user);
        List<User> GetAllUsers();
        User GetUserById(int id);
    }
}