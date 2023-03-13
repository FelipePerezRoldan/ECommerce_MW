using System.ComponentModel.DataAnnotations;

namespace Ecommerce_MW.DAL.Entities
{
    public class Entity
    {
        [Key]
        //[Required] it's not necesary cause is primarykey
        public Guid Id { get; set; }
        [Display(Name = "Creation date")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Modification date")]
        public DateTime? ModifiedDate { get; set; }
    }
}
