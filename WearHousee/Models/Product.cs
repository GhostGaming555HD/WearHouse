using System.ComponentModel.DataAnnotations;

namespace WearHousee.Models
{
    public class Product
    {
        [Key]
        public int no { get; set; }

        [MaxLength(100)]
        public string category { get; set; } = "";
    }
}
