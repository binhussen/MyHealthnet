using System;

namespace WebApp.Context
{
    public class Users
    {
        public int UsersId { get; set; }
        public string FirstName { get; set; }
        public string middleName { get; set; }
        public string lasatName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string phoneNo { get; set; }
        public string imageURL { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? isAdmin { get; set; }
        public bool? isCloudAdmin { get; set; }
        public bool isActive { get; set; }
    }
}
