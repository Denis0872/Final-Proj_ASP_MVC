using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class deseases
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public deseases()
        {
            this.infoaboutanimal = new HashSet<infoaboutanimal>();
        }
        [Key]
        public int iddeseases { get; set; }
        public string desease { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoaboutanimal> infoaboutanimal { get; set; }
    }
}