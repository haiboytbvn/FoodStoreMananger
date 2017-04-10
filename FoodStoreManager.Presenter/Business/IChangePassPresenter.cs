using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreManager.Data.DataModels;
using FoodStoreManager.Presenter.Models;


namespace FoodStoreManager.Presenter.Business
{
    public interface IChangePassPresenter : IPresenter<ChangePasswordViewModel>
    {
        Task<IdentityResult> ChangePasswordAsync(string userId, string currentPassword, string newPassword);
        Task<ApplicationUser> FindByIdAsync(string userId);
    }
}
