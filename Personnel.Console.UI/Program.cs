using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;
using Personnel.core.Domain.Data;
using Personnel.core.Domain.Models.Domain;
using Personnel.Core.UnitOfWork.Persistence;

namespace Personnel.Console.UI
{
    class Program
    {
        private static readonly DbContextOptions<PersonnelDbContext> _options;
        static void Main(string[] args)
        {
            //UnitOfWork unitOfWork = new UnitOfWork(new PersonnelDbContext(options:new DbContextOptions<PersonnelDbContext>()));
            //unitOfWork.Department.Add(new Department()
            //{
            //    Name = "Robotic",
            //    IsActive = true,
            //    CreatedDate = DateTime.Now
            //});
            //unitOfWork.Complete();
            //unitOfWork.Personnel.Add(new Personnels()
            //{
            //    Name = "Cebrail",
            //    LastName = "Robotic",
            //    Department= new Department()



            //});
            using var unitOfWork = new UnitOfWork(new PersonnelDbContext(_options));
            unitOfWork.Department.Add(new Department()
            {
                Name = "Robotic",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

        }
    }
}
