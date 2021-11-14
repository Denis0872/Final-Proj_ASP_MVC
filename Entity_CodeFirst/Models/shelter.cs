using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class shelter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shelter()
        {
            this.animals = new HashSet<animals>();
        }
        [Key]
        public int idshelter { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string LimitAnimals { get; set; }
        public string CountAnimals { get; set; }
        public Nullable<int> idRegion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animals> animals { get; set; }
        public virtual region region { get; set; }
    }
}