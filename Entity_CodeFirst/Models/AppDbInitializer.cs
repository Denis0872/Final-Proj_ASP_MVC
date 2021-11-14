using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entity_CodeFirst.Models
{
    public class AppDbInitializer:DropCreateDatabaseAlways<ApplicationDbContext>
    {
        public string Name { get; private set; }

        protected override void Seed(ApplicationDbContext context)
        {
            #region Managers
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            #endregion
            #region Roles
            var roleAdmin = new IdentityRole( Name = "admin");
            var roleUser = new IdentityRole( Name = "user");
            var roleShelter = new IdentityRole( Name = "shelter");

            roleManager.Create(roleAdmin);
            roleManager.Create(roleUser);
            roleManager.Create(roleShelter);
            #endregion
            #region Users
            var admin = new ApplicationUser { Email = "denispetergof@gmail.com", UserName = "Denis" };
            string passwordAdmin = "Den-5118097";
            var resultAdmin = userManager.Create(admin, passwordAdmin);
            if (resultAdmin.Succeeded)
            {
                userManager.AddToRole(admin.Id, roleAdmin.Name);
            }
            var user = new ApplicationUser { Email = "denis1@mail.ru", UserName = "Denis" };
            string passwordUser = "Den-5118097";
            var resultUser = userManager.Create(user, passwordUser);
            if (resultAdmin.Succeeded)
            {
                userManager.AddToRole(admin.Id, roleAdmin.Name);
            }
            var shelter = new ApplicationUser { Email = "denis1@yandex.ru", UserName = "Denis" };
            string passwordShelter = "Den-5118097";
            var resultShelter = userManager.Create(shelter, passwordShelter);
            if (resultAdmin.Succeeded)
            {
                userManager.AddToRole(admin.Id, roleAdmin.Name);
            }
            #endregion
            base.Seed(context);
        }
    }
}