using System;
using System.ComponentModel.DataAnnotations;

namespace Entitiy

{
    [Serializable]
    public class User
    {

        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; } = Role.Admin;
        public int SecurityLevel { get; set; }
        
        public User()
        {
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}