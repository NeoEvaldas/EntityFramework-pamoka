using System.ComponentModel.DataAnnotations;

namespace EntityFramework_pamoka.Models
{
    public class Vartotojas
    {
        [Key]
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Slaptazodis { get; set; }
        public string Pastas { get; set; }
    }
}
