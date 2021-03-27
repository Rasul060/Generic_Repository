using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Personnel.core.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Personnel.core.Domain.Models.Domain;

namespace Personnel.core.Domain.Data
{
    public class PersonnelDbContext:DbContext
    {
        private readonly DbContextOptions<PersonnelDbContext> _options;
        public PersonnelDbContext(DbContextOptions<PersonnelDbContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<Personnels>Personnels { get; set; }
        public DbSet<Department>Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personnels>()
                .HasOne<Department>(x => x.Department)
                .WithMany(z => z.Presonnels)
                .HasForeignKey(f => f.DepartmentId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
