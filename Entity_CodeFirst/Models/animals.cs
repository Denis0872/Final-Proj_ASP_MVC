using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class animals
    {
        [Key]
        public int idAnimals { get; set; }
        [DisplayName("тип животного")]
        [Required]
        public int KindAnimals { get; set; }
        [DisplayName("приют")]
        [Required]
        public int Shelter { get; set; }
        [DisplayName("информация о животном")]
        [Required]
        public int InfoAnimals { get; set; }
        [DisplayName("лечение")]
        [Required]
        public int Treatment { get; set; }

        public virtual infoaboutanimal infoaboutanimal { get; set; }
        public virtual kindanimals kindanimals1 { get; set; }
        public virtual shelter shelter1 { get; set; }
        public virtual treatment treatment1 { get; set; }
    }
}