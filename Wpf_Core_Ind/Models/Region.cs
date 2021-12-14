using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Core_Ind.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string RegionDiscription { get; set; } // наименование области

        public List<Territory> Territory { get; set; } // навигационное свойство

    }

}
