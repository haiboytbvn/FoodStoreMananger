using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using FoodStoreManager.Data.DataModels;

namespace FoodStoreManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        #region Constructors

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        #endregion

        #region Tables

        public DbSet<TeamDataModel> Teams { get; set; }

        #endregion
    }
}
