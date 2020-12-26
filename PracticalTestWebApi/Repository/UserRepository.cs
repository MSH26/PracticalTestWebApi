using PracticalTestWebApi.Context;
using PracticalTestWebApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticalTestWebApi.Repository
{
    public class UserRepository
    {
        readonly DatabaseContext context = new DatabaseContext();
        public User GetUserByUserName(string userName)
        {
            return context.Users.FirstOrDefault(u => u.UserName.Equals(userName.Trim()));
        }
        public User GetUser(long userId)
        {
            return context.Users.FirstOrDefault(s => s.UserId == userId);
        }
    }
}