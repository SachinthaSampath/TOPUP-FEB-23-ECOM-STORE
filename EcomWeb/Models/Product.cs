using System.ComponentModel.DataAnnotations;

namespace EcomWeb.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

    }
}
