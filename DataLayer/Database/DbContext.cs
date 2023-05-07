using DataLayer.Models;
using DataLayer.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class HelpDuxDbContext : DbContext
    {
        public HelpDuxDbContext(DbContextOptions<HelpDuxDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Website> Websites { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new WebsiteCOnfigurations());
        //    modelBuilder.ApplyConfiguration(new UserConfiguration());
        //}
    }
}
