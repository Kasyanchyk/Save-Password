using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SavePasswords.Models
{
    public class PasswordsDbContext : DbContext
    {
        public PasswordsDbContext(DbContextOptions<PasswordsDbContext> options) :base(options)
        { 
        }

        public DbSet<Passwords> Passwords { get; set; }
    }
}
