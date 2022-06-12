namespace Worldperfumluxury.Models
{
    public abstract class BaseEntity
    {
        public bool IsActive { get; set; } = true;
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsMain { get; set; }

        //public Nullable<datetime> createdat { get; set; }
        //public nullable<datetime> deletedat { get; set; }
        //public nullable<datetime> updatedat { get; set; }


    }
}
