using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class kindanimals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kindanimals()
        {
            this.animals = new HashSet<animals>();
            this.peopleinfo = new HashSet<peopleinfo>();
        }
        [Key]
        public int idkindAnimals { get; set; }
        public string KindAnimal { get; set; }
        public string SizeAnimal { get; set; }
        public System.Nullable<int> Feeding { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animals> animals { get; set; }
        public virtual feeding feeding1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<peopleinfo> peopleinfo { get; set; }
    }
}