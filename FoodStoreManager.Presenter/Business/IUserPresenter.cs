using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Business
{
    public interface IUserPresenter : IPresenter<UserViewModel>, ILoginPresenter, IRegisterPresenter, ILogoutPresenter, IManagePresenter, IChangePassPresenter, IUpdateDisplayNamePresenter
    {
    }
}
