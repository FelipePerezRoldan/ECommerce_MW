using System.ComponentModel.DataAnnotations;

namespace Ecommerce_MW.DAL.Entities
{
    public class Entity
    {
        [Key]
        //[Required] it's not necesary cause is primarykey
        public Guid Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
