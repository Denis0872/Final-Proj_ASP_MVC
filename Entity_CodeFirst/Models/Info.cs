using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_CodeFirst.Models
{
    public class InfoContext : DropCreateDatabaseIfModelChanges<EntityDbContext>
        {
            protected override void Seed(EntityDbContext context)
            {
              //  context.InfAnim.Add(new infoaboutanimal { Name = "Имя", Weight=  10, Height = 20, Deseases = "глисты" });
            base.Seed(context);
        }
        }
    
}