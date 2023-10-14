using System.ComponentModel.DataAnnotations;

namespace EcomWeb.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public String Name { get; set; }

        public String Address { get; set; }
    }
}
