namespace TestTask.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; } 

        public int UserId { get; set; }

        public virtual UserModel User { get; set; }
    }
}
