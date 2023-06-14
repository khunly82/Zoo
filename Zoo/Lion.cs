using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Table("Lion")]
    public class Lion: Animal
    {
        public string Couleur { get; set; }
    }
}
