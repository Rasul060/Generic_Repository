using System;
using System.Collections.Generic;
using System.Text;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.Repository.implementation.Persistences;
using Personnel.Core.Repository.implementation.Repositories;

namespace Personnel.Core.UnitOfWork.Core
{
    public interface IUnitOfWork:IDisposable
    {
         PersonnelRepository Personnel { get; }
         IDepartmentRepository Department { get; }
        int Complete();
        

    }
}
