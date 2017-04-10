﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Business
{
    public interface IManagePresenter
    {
        bool HasPassword();
        Task<string> GetPhoneNumberAsync(string userId);
        Task<bool> GetTwoFactorEnabledAsync(string userId);
        Task<IList<UserLoginInfo>> GetLoginsAsync(string userId);
        Task<bool> TwoFactorBrowserRememberedAsync(string userId);
        //Return a model
        IndexViewModel FindUserByID(string UserId);
        UpdateRolesViewModel FindUserRoleById(string UserId);
        bool IsRoleExist(string role);
        IdentityResult AddRole(string UserId, string UserRole);
        Task<IdentityResult> CreateRole(string UserRole);
        IdentityResult RemoveRole(string UserId, string UserRole);
    }
}
