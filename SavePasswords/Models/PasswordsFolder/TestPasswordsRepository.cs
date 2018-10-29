using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavePasswords.Models
{
    public class TestPasswordsRepository : IPasswordsRepository
    {
        public IEnumerable<Passwords> Passwords => new List<Passwords>
        {

        };
    }
}
