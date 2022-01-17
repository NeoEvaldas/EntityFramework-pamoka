using System.ComponentModel.DataAnnotations;

namespace EntityFramework_pamoka.Models
{
    public class Daiktas
    {
        [Key]
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public int? SavininkasId { get; set; }
    }
}
