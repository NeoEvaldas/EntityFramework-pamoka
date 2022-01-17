using System.ComponentModel.DataAnnotations;

namespace EntityFramework_pamoka
{
    public class Automobilis
    {
      
            [Key]
            public int Id { get; set; }
            public string Marke { get; set; }
            public string Modelis { get; set; }
            public int? SavininkoId { get; set; }
    }

}
