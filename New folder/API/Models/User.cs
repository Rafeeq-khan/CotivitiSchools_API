using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }

        public string RoleId { get; set; }
    }
}
