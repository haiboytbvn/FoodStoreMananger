using System;
using FoodStoreManager.Data.DataModels;
using FoodStoreManager.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using FoodStoreManager.Presenter.Models;
using FoodStoreManager.Data.Common;

namespace FoodStoreManager.Presenter.Business
{
    public class LoginStatusPresenter : ILoginStatusPresenter
    {
        public LoginStatusViewModel GetCurrentUser(string email)
        {

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                //throw new DatabaseNotFoundException();
           
            var model = manager.FindByEmail(email);
            if (model == null)
            {
                throw new UserNotFoundException();
            }

            var viewModel = new LoginStatusViewModel();
            viewModel.DisplayName = model.DisplayName;
            return viewModel;

        }
    }
}
