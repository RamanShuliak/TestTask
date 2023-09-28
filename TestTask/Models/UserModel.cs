using TestTask.DataBase.Enums;

namespace TestTask.Models
{
    public class UserModel
    {
        public int Id { get; set; } 

        public string Email { get; set; }

        public UserStatus Status { get; set; }

        public virtual List<OrderModel> Orders { get; set; }
    }
}
