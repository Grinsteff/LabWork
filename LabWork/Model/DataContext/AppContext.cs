using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace LabWork.Model.DataContext
{
    public class AppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public AppContext()
        {
            Database.EnsureCreated();
        }

        string folderpath = Path.Combine(Directory.GetCurrentDirectory(), @"DB\LabWork.db");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {folderpath}");
        }
    }
}
