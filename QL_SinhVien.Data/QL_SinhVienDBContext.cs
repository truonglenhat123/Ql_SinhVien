using Microsoft.EntityFrameworkCore;
using QL_SinhVien.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_SinhVien.Data
{
    public class QL_SinhVienDBContext: DbContext
    {
        public QL_SinhVienDBContext(DbContextOptions<QL_SinhVienDBContext> options) : base(options)
        {

        }
        public DbSet<SinhVienEntities> SinhVienDB { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server =LAPTOP-661GUS93\\TRUONGPC;Database=StudentsManagermentDB;Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
