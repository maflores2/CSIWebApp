using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSIWebApp1.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSIWebApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<RequestMetric> RequestMetric { get; set; }
        public DbSet<RequestMetricsDetails> RequestMetricsDetails { get; set; }
        public DbSet<RequestMetricsExt> RequestMetricsExt { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestMetric>().ToTable("RequestMetrics");
            modelBuilder.Entity<RequestMetricsDetails>().ToTable("RequestMetricsDetails");
            modelBuilder.Entity<RequestMetricsExt>().ToTable("RequestMetricsExtDetails");
            base.OnModelCreating(modelBuilder);
        }
    }
}

