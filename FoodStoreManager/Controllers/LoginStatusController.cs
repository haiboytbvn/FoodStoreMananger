using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodStoreManager.Presenter.Models;
using FoodStoreManager.Presenter.Business;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using FoodStoreManager.Data.Common;

namespace FoodStoreManager.Controllers
{

    public class LoginStatusController : Controller
    {
        public ILoginStatusPresenter LoginStatusPresenter;

        public LoginStatusController()
        {
            LoginStatusPresenter = new LoginStatusPresenter();
        }
        // GET: LoginStatus
        public ActionResult DisplayName()
        {
            try
            {
                var model = LoginStatusPresenter.GetCurrentUser(User.Identity.GetUserName());
                if (User.Identity.IsAuthenticated)
                {
                    return PartialView("~/Views/Shared/_AuthenticatedPartial.cshtml", model);
                }
                else
                {
                    return PartialView("~/Views/Shared/_UnAuthenticatedPartial.cshtml");
                }
            }
            catch (UserNotFoundException ex)
            {
                return PartialView("~/Views/Shared/_UnAuthenticatedPartial.cshtml");
            }         
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}