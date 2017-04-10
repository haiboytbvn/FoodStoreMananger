using System.Web.Mvc;
using FoodStoreManager.Presenter.Business;
using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Web.Common.Base
{
    public class ControllerBase : Controller
    {
        protected virtual ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
