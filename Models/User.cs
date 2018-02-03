using System;
namespace RapGeekBlog.Models
{
    public class User
    {
        public int UserId
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public string PasswordHash
        {
            get;
            set;
        }

        public string Firstname
        {
            get;
            set;
        }

        public string Lastname { get; set; }

        public string Email
        {
            get;
            set;
        }

        public DateTime Created { get; set; }
    }
}
