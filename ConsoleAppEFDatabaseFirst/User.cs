using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleAppEFDatabaseFirst
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
