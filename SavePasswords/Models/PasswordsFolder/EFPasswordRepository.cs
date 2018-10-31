using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavePasswords.Models.PasswordsFolder
{
    public class EFPasswordRepository: IPasswordsRepository
    {
        private AppIdentityDbContext context;

        public EFPasswordRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Password> Passwords => context.Passwords;

        public void AddPassword (Password password)
        {
            context.Passwords.Add(password);
            context.SaveChanges();
        }
        
    }
}
