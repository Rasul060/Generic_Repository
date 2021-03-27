using System;
using System.Collections.Generic;
using System.Text;
using Personnel.core.Domain.Models.Base;

namespace Personnel.core.Domain.Models.Domain
{
    public class Department:BaseEntity
    {
        public Department()
        {
            Presonnels = new HashSet<Personnels>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Personnels> Presonnels { get; set; }
    }
}
