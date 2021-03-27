using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Personnel.core.Domain.Data;

namespace Personnel.core.Domain
{
    public class AppDbContextFactory:IDesignTimeDbContextFactory<PersonnelDbContext>
    {
        public PersonnelDbContext CreateDbContext(string[] args)
        {
            var builder =new DbContextOptionsBuilder<PersonnelDbContext>();
            builder.UseSqlServer(@"Server=DESKTOP-HKBHGD3;Database=PersonnelDb;Trusted_Connection=True;");
            return new PersonnelDbContext(builder.Options);
        }
    }
}
