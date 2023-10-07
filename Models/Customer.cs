using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcomWeb.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [Phone]
        [RegularExpression(@"^(\+\d{1, 2}\s)?\(?\d{3}\)?[\s.-]?\d{ 3}[\s.-]?\d{ 4}$")]
        public string Telephone { get; set; }


    }
}
