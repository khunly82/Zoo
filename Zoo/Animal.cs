using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    [Table("Animal")]
    public class Animal
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        [Column("Genre")]
        public Genre Sexe { get; set; }

    }
}
