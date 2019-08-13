using System;
using SQLite;

namespace fotisPhysio.Models
{
    public class Users
    {
        public Users()
        {


        }
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}
