using System.ComponentModel.DataAnnotations;

namespace Ecommerce_MW.DAL.Entities
{
    public class Country : Entity
    {
        [Required(ErrorMessage ="The field {0} is mandatory.")] //Data notation for NOT NULL
        [MaxLength(50,ErrorMessage ="The field {0} must have {1} characters at most.")]
        [Display(Name="Country")]
        public string Name { get; set; }
    }
}
