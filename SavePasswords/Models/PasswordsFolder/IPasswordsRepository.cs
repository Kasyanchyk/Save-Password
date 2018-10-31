using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavePasswords.Models
{
    public interface IPasswordsRepository
    {
        IEnumerable<Password> Passwords { get; }

        void AddPassword(Password pass);
    }
}
