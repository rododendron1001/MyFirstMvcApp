using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstMvcApplication.Models;

namespace MyFirstMvcApplication.Data
{
    public class MyFirstMvcApplicationDbContext : DbContext
    {
        public MyFirstMvcApplicationDbContext (DbContextOptions<MyFirstMvcApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstMvcApplication.Models.ContactListEntry> ContactListEntry { get; set; }
    }
}
