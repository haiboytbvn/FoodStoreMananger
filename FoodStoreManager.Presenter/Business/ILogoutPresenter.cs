using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Business
{
    public interface ILogoutPresenter : IPresenter<UserViewModel>
    {
        void SignOut();
    }
}
