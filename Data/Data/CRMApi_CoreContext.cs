using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Data.Data
{
    public class CRMApi_CoreContext : DbContext
    {
        public CRMApi_CoreContext(DbContextOptions<CRMApi_CoreContext> options)
            : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
