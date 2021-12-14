using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Core_Ind.Models
{
    public class Employee
    {
        public int Id { get; set; } // первичный ключ
        public string LastName { get; set; } // фамилия имя
        public string FirstName  { get; set; } // имя
        public string SecondName { get; set; } // Отчество
        public string Title { get; set; } // Должность
        public DateTime BirthDay { get; set; } // дата рождения
        public string Address  { get; set; } // адрес
        public string City  { get; set; } // город
        public string Region  { get; set; } // область
        public string Phone  { get; set; } // телефон
        public string Email  { get; set; } // электронная почта

        

    }

    

}
