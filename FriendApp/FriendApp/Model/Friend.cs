using System;
using System.Collections.Generic;
using System.Text;

namespace FriendApp.Model
{
    using SQLite;
    public class Friend
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string  Phone { get; set; }
    }
}
