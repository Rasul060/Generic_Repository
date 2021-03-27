using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Personnel.core.Domain.Data;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.Repository.implementation.Repositories;
using Personnel.Core.Repository.Persistence;

namespace Personnel.Core.Repository.implementation.Persistences
{
    public class DepartmentRepository: Repository<Department> ,IDepartmentRepository
    {
        public DepartmentRepository(PersonnelDbContext context) : base(context)
        {
        }
        public PersonnelDbContext PersonnelDbContext => Context as PersonnelDbContext;


        public IQueryable<Department> GetDepartmentWithPersonnel(Expression<Func<Department, bool>> predicate)
        {
            return Context.Set<Department>().Include(x => x.Presonnels).Where(predicate);
        }
    }
}
