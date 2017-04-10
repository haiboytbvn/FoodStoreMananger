using System.ComponentModel.DataAnnotations;

namespace FoodStoreManager.Data.DataModels
{
    public class DataModelBase
    {
        [Key]
        public int ID { get; set; }
    }
}
