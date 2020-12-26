using System;

namespace PracticalTestWebApi.Entity
{
    public class User
    {
       // [Key]
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public int Role { get; set; }
        public int IsActive { get; set; }
        public DateTime CreationDtTm { get; set; }
        public DateTime LastUpdateDtTm { get; set; }
    }
}