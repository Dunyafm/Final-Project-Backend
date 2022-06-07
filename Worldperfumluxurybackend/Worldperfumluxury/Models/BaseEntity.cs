using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worldperfumluxury.Models
{
    public abstract class BaseEntity
    {
        public bool IsActive { get; set; } = true;
        public int Id { get; set; }
        //public bool IsDeleted { get; set; }
        //public Nullable<DateTime> CreatedAt { get; set; }
        //public Nullable<DateTime> DeletedAt { get; set; }
        //public Nullable<DateTime> UpdatedAt { get; set; }


    }
}
