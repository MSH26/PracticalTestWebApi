using PracticalTestWebApi.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace PracticalTestWebApi.Models
{
    public class UserDto
    {
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

        public static UserDto CreateUserDto(User user)
        {
            return new UserDto()
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Password = user.Password,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                Gender = user.Gender,
                Role = user.Role,
                IsActive = user.IsActive,
                CreationDtTm = user.CreationDtTm,
                LastUpdateDtTm = user.LastUpdateDtTm,
            };
        }
    }
}