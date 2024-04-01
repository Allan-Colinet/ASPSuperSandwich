using System.ComponentModel.DataAnnotations;

namespace SuperSandwich15000.Models
{
    public class Sandwich
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nom { get; set; }
        [Required]
        public decimal Prix { get; set; }

    }
}
