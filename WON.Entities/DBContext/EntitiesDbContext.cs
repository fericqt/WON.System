using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WON.Entities.Models;

namespace WON.Entities.DBContext {
    public class EntitiesDbContext : DbContext {
        public EntitiesDbContext(DbContextOptions<EntitiesDbContext> options) : base (options) {
            
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Prizes> Prizes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }

    }
}
