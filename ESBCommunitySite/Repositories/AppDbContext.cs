using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESBCommunitySite.Models;
using Microsoft.EntityFrameworkCore;

namespace ESBCommunitySite.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MessageInfo> Messages { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<PotentialMember> PotentialMembers { get; set; }
    }
}
