using System.ComponentModel.DataAnnotations;

namespace WearHousee.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string category { get; set; } = "";
    }
}
