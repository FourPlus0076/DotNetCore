using System.ComponentModel.DataAnnotations;

namespace AperioIndia
{
#nullable disable
    public class ProductCategory
    {
        [Key]
        public int ID { get; set; }
        public string PName { get; set; }
        public string PDetails { get; set; }
        public string PImage { get; set; }
        public string meta_title { get; set; }
        public string meta_desc { get; set; }
        public bool IsActive { get; set; }       
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string About { get; set; }

    }
}
