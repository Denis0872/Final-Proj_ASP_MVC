using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class feeding
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public feeding()
        {
            this.kindanimals = new HashSet<kindanimals>();
        }
        [Key]
        public int idfeeding { get; set; }
        public string ingredient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kindanimals> kindanimals { get; set; }
    }
}