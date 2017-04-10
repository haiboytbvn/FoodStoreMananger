using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Business
{
    public interface IRegisterPresenter : IPresenter<RegisterViewModel>
    {
        UserViewModel Register(RegisterViewModel model);

        Task<IdentityResult> CreateAsync(RegisterViewModel model);
    }
}
