using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Personnel.core.Domain.Models.Base;

namespace Personnel.core.Domain.Models.Domain
{
    public class Personnels:BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long DepartmentId { get; set; }
        public Department Department { get; set; }

    }

   
}
