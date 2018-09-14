using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WirelessMedia.Models
{
    public partial class WirelessMediaContext : DbContext
    {
        
        public WirelessMediaContext(DbContextOptions<WirelessMediaContext> opcije)
            : base(opcije)
        {
        }

        public virtual DbSet<Proizvod> Proizvodi { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
