namespace TestTask.DataBase.Entities
{
    public class User : IBaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public List<Order> Orders { get; set; }
    }
}
