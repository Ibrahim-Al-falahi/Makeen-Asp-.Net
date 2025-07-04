﻿namespace Eventom.Models.UserModule
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public UserType UserType { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }

    }
}
