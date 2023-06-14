using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Table("Elephant")]
    public class Elephant: Animal
    {
        public int Taille { get; set; }
    }
}
