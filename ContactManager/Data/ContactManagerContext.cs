using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

namespace ContactManager.Data
{
    public class ContactManagerContext : DbContext
    {
        public ContactManagerContext (DbContextOptions<ContactManagerContext> options)
            : base(options)
        {
        }

        public DbSet<ContactManager.Models.Contact> Contact { get; set; } = default!;
    }
}
