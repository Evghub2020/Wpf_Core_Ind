using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Core_Ind.Models
{
    public class Territory
    {
        public int Id { get; set; }
        public string Discription { get; set; } // название города

        public int RegionId { get; set; } // внешний ключ Territory
        public Region Region { get; set; } // навигационное свойство

        public List<Employee_Territory> Employee_Territory { get; set; }
    }
}
