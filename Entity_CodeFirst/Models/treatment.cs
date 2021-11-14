using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class treatment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public treatment()
        {
            this.animals = new HashSet<animals>();
        }
        [Key]
        public int idtreatment { get; set; }
        public string treatment1 { get; set; }
        public Nullable<System.DateTime> Data_start { get; set; }
        public Nullable<System.DateTime> Data_Final { get; set; }
        public string address { get; set; }
        public Nullable<int> region { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animals> animals { get; set; }
        public virtual region region1 { get; set; }
    }
}