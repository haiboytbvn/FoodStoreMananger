﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;
using FoodStoreManager.Data.DataModels;

namespace FoodStoreManager.Data.DataModels
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //add Team navigation property
        //add Display Name property
        public string DisplayName { get; set; }
        public int? TeamID { get; set; }
        public virtual TeamDataModel Team { get; set; }
    }
}
