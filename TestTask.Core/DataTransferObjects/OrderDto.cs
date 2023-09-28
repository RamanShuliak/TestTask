using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Core.DataTransferObjects
{
    public class OrderDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public int UserId { get; set; }

        public virtual UserModel User { get; set; }
    }
}
