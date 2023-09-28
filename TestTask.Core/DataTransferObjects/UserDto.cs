using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.DataBase.Entities;
using TestTask.DataBase.Enums;

namespace TestTask.Core.DataTransferObjects
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public UserStatus Status { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
