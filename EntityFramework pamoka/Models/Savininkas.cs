using System.ComponentModel.DataAnnotations;

namespace EntityFramework_pamoka.Models
{
    public class Savininkas
    {
        [Key]
        public int Id { get; set; }
        public string Vardas { get; set; }
        
    }
}
