using System.Collections.Generic;
using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Business
{
    public interface ITeamPresenter : IPresenter<TeamViewModel>
    {
        List<TeamViewModel> ListAll();

        TeamViewModel GetTeamById(int? id);

        void InsertTeam(CreateTeamViewModel team);

        void UpdateTeam(int id, EditTeamViewModel team);

        void DeleteTeam(int id);
        
    }
}
