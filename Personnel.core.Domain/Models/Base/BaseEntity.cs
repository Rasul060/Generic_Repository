using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel.core.Domain.Models.Base
{
    public class BaseEntity
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActive { get; set; }
    }
}
