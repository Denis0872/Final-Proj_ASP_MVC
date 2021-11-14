using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_CodeFirst.Models
{
    public class EntityDbContext: DbContext
    {
        public DbSet<animals> Anim { get; set; }
        public DbSet<deseases> Des { get; set; }
        public DbSet<feeding> Feed { get; set; }
        public DbSet<infoaboutanimal> InfAnim { get; set; }
        public DbSet<kindanimals> Kindanimal { get; set; }
        public DbSet<peopleinfo> PplInf { get; set; }
        public DbSet<region> Reg { get; set; }
        public DbSet<shelter> Shelt { get; set; }
        public DbSet<treatment> Treat { get; set; }
    }

    
}