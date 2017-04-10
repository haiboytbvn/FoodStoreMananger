﻿using System;
using System.Web.Mvc;
using FoodStoreManager.Data.Common;
using FoodStoreManager.Presenter.Business;
using FoodStoreManager.Presenter.Models;
using FoodStoreManager.Presenter.Validations;

namespace FoodStoreManager.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles ="Admin")]
    public class TeamController : Controller
    {
        #region Properties

        protected ITeamPresenter TeamPresenterObject;

        #endregion

        #region Constructors

        public TeamController()
        {
            TeamPresenterObject = new TeamPresenter();
        }

        #endregion

        // GET: Admin/Team
        public ActionResult Index()
        {
            var teams = TeamPresenterObject.ListAll();
            return View("Index", teams);
        }

        // GET: Admin/Team/Details/5
        public ActionResult Details(int? id)
        {
            try
            {
                var team = TeamPresenterObject.GetTeamById(id);
                return View("Details", team);
            }
            catch (TeamNotFoundException e)
            {
                return View("ResultNotFoundError");
            }
            catch (Exception e)
            {
                return View("ResultNotFoundError");
            }
        }


        // GET: Admin/Team/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Team/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name")] TeamViewModel team)
        {
            if (ModelState.IsValid)
            {
                string teamName = team.Name.Trim();
                var createdTeam = new CreateTeamViewModel { Name = teamName };
                TeamPresenterObject.InsertTeam(createdTeam);
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Admin/Team/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                var updatedTeam = TeamPresenterObject.GetTeamById(id);
                return View("Edit", updatedTeam);
            }
            catch (TeamNotFoundException e)
            {
                return View("ResultNotFoundError");
            }
            catch (Exception e)
            {
                return View("ResultNotFoundError");
            }
        }

        // POST: Admin/Team/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection, [Bind(Include = "Name, ID")] TeamViewModel team)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string teamName = team.Name;
                    var updatedTeam = new EditTeamViewModel { Name = teamName };
                    TeamPresenterObject.UpdateTeam(id, updatedTeam);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (TeamNotFoundException e)
            {
                return View("ResultNotFoundError");
            }
        }

        // GET: Admin/Team/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                var deletedTeam = TeamPresenterObject.GetTeamById(id);
                return View("Delete", deletedTeam);
            }
            catch (TeamNotFoundException e)
            {
                return View("ResultNotFoundError");
            }
            catch (Exception e)
            {
                return View("ResultNotFoundError");
            }
        }

        // POST: Admin/Team/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                TeamPresenterObject.DeleteTeam(id);
                return RedirectToAction("Index");
            }
            catch (TeamNotFoundException e)
            {
                return View("ResultNotFoundError");
            }
        }
    }
}
