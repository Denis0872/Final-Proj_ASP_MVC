using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class infoaboutanimal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infoaboutanimal()
        {
            this.Animals = new HashSet<animals>();
        }
        [Key]
        public int IdinfoAboutAnimal { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Durationin_in__helter_in_monthes { get; set; }
        public string Deseases { get; set; }
        public int SizeAnimal { get; set; }
        public string PhotoAnimal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animals> Animals { get; set; }
        public virtual deseases deseases1 { get; set; }
    }
}