using System.ComponentModel.DataAnnotations;

namespace EntityFramework_pamoka
{
    public class Mopedas
    {
      
            [Key]
            public int Id { get; set; }
            public string Marke { get; set; }
            public string Modelis { get; set; }
            public int? SavininkoId { get; set; }
    }

}
