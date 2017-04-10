using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStoreManager.Data.Repositories
{
    public class RepositoryBase
    {
        protected ApplicationDbContext dataContext;

        public RepositoryBase()
        {
            dataContext = new ApplicationDbContext();
        }
    }
}
