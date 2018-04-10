namespace WebApplication2.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity.Migrations;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            this.AddUserAndRoles();
        }

        private bool AddUserAndRoles()
        {
            bool success = false;
            var idManager = new IdentityManager();

            success = idManager.CreateRole("Admin");
            if (!success) return success;

            success = idManager.CreateRole("CanEdit");
            if (!success) return success;

            success = idManager.CreateRole("User");
            if (!success) return success;

            return success;
        }
    }
}