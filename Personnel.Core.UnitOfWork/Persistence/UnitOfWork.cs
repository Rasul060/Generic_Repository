using System;
using System.Collections.Generic;
using System.Text;
using Personnel.core.Domain.Data;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.Repository.implementation.Persistences;
using Personnel.Core.Repository.implementation.Repositories;
using Personnel.Core.UnitOfWork.Core;

namespace Personnel.Core.UnitOfWork.Persistence
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly PersonnelDbContext _context;

        public UnitOfWork(PersonnelDbContext context)
        {
            _context = context;
            Personnel = new PersonnelRepository(_context);
            Department = new DepartmentRepository(_context);
        }
        public PersonnelRepository Personnel { get; }
        public IDepartmentRepository Department { get; }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
