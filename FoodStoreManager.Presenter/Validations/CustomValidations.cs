using System.ComponentModel.DataAnnotations;
using System.Linq;
using FoodStoreManager.Data.Repositories;
using FoodStoreManager.Presenter.Models;

namespace FoodStoreManager.Presenter.Validations
{
    public class TeamUniqueValidationAttribute : ValidationAttribute
    {
        ITeamRepository teamRepository = new TeamRepository();


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            TeamViewModel team = validationContext.ObjectInstance as TeamViewModel;
            var existedTeam = teamRepository.GetExistedTeamByName(team.Name.Trim());
            if (existedTeam.Any() && existedTeam.First().ID != team.ID)
            {
                return new ValidationResult("Team already exist!");
            }
            return ValidationResult.Success;
        }

    }
}
