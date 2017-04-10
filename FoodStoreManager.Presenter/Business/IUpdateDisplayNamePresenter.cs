using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStoreManager.Presenter.Models;
using FoodStoreManager.Data.DataModels;

namespace FoodStoreManager.Presenter.Business
{
    public interface IUpdateDisplayNamePresenter
    {
        UpdateDisplayNameViewModel GetCurrentUserById(string id);

        void UpdateDisplayNameInDB(string UserId, string NewDisplayName);
    }
}

