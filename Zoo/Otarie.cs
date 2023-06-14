
using System.ComponentModel.DataAnnotations.Schema;

namespace Zoo
{
    [Table("Otarie")]
    public class Otarie: Animal
    {
        public int Jonglage { get; set; }
    }
}
