using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.DataBase.Entities
{
    public class Order : IBaseEntity
    {
        // Гораздо надёжнее в качестве идентификаторов использовать тип Guid вместо int.
        // То же касается сущностей User. Однако я оставил int, как было указано в примере.
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
