using FoodStoreManager.Common;

namespace FoodStoreManager.Data.Common
{
    public class TeamNotFoundException : NotFoundException
    {
        public TeamNotFoundException() { }
        public TeamNotFoundException(string message) { }
    }
}
