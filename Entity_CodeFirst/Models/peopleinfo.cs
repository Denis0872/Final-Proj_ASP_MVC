using System;
using System.ComponentModel.DataAnnotations;

namespace Entity_CodeFirst.Models
{
    public class peopleinfo
    {
        [Key]
        public int idpeopleInfo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Nullable<int> kindAnimals { get; set; }
        public Nullable<int> region { get; set; }

        public virtual kindanimals kindanimals1 { get; set; }
        public virtual region region1 { get; set; }
    }
}