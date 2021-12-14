using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Core_Ind.Models
{
    public class Employee_Territory
    {
        public int Id { get; set; } // внешний ключ Employee
        public int EmployeeId { get; set; } // внешний ключ Employee
        public int TerritoryId { get; set; } // внешний ключ Territory

        public Employee Employee { get; set; } // навигационное свойство
        public Territory Territory { get; set; } // навигационное свойство
        
    }
}
