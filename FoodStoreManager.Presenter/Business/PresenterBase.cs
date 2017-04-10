using System.Data.Entity;
using FoodStoreManager.Data;

namespace FoodStoreManager.Presenter.Business
{
    /// <summary>
    /// base for all presenters
    /// </summary>
    public class PresenterBase
    {
        #region Properties


        protected ApplicationDbContext DataContext;

        #endregion

        #region Methods

        public PresenterBase()
        {
        }

        #endregion
    }
}
