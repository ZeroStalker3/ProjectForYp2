using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForYp2.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public decimal Phone { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Type Type { get; set; } = null!; 

    }
}
