using System.ComponentModel.DataAnnotations;

namespace Zoo.Web.Models
{
    public class LionCreateViewModel
    {
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z]*$")]
        public string? Nom { get; set; }

        [Required]
        public Genre Sexe { get; set; }

        [Required]
        public string Couleur { get; set; }
    }
}
