using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.Repository.Repositories;

namespace Personnel.Core.Repository.implementation.Repositories
{
    public interface IPersonnelRepository:IRepository<Personnels>
    {
        IQueryable<Personnels> GetPersonnelsWithDepartments(Expression<Func<Personnels ,bool>> predicate);

    }
}
