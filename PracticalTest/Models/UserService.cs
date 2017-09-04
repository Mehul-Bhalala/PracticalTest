using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class UserService
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long ServiceId { get; set; }

        public Service Service { get; set; }
    }
}
