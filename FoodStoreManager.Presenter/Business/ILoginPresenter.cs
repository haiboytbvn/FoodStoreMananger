using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using FoodStoreManager.Data.DataModels;
using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Business
{
    public interface ILoginPresenter : IPresenter<LoginViewModel>
    {
        Task<SignInStatus> PasswordSignInAsync(string email, string passWord, bool rememberMe, bool shouldLockOut);

        Task SignInAsync(ApplicationUser user, bool isPersistent, bool rememberBrowser);
    }
}
