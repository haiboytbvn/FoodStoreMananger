using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Business
{
    public interface ILoginStatusPresenter
    {
         LoginStatusViewModel GetCurrentUser(string email);
    }
}
