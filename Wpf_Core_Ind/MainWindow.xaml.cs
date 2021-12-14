using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_Core_Ind.Models;

namespace Wpf_Core_Ind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void initdb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта Region
                Region reg1 = new Region { RegionDiscription = "Московская область" };
                Region reg2 = new Region { RegionDiscription = "Краснодарский край" };
                Region reg3 = new Region { RegionDiscription = "Ростовская область" };
                db.Regions.Add(reg1);
                db.Regions.Add(reg2);
                db.Regions.Add(reg3);
                db.SaveChanges();

 
                // создаем четыре объекта Employee
                Employee emp1 = new Employee
                {
                    LastName = "Симоненко",
                    FirstName = "Евгений",
                    SecondName = "Евгеньевич",
                    Title = "Директор",
                    BirthDay = new DateTime(1999, 10, 16),
                    Address = "ул.Петренко, 218",
                    City = "ст.Староминская",
                    Phone = "89284273627",
                    Email = "zhenya.simonenko.1999@mail.ru",
                    Region = "Краснодарский край"
                };
                Employee emp2 = new Employee
                {
                    LastName = "Катрушенко",
                    FirstName = "Анатолий",
                    SecondName = "Алексеевич",
                    Title = "Менеджер",
                    BirthDay = new DateTime(2000, 07, 28),
                    Address = "ул.Переездная,30",
                    City = "ст.Тбилисская",
                    Phone = "89294819633",
                    Email = "katrushenko@mail.ru",
                    Region = "Краснодарский край"
                };
                Employee emp3 = new Employee
                {
                    LastName = "Незатейлов",
                    FirstName = "Владимир",
                    SecondName = "Александрович",
                    Title = "Бухгалтер",
                    BirthDay = new DateTime(1973, 02, 20),
                    Address = "ул.Большая Садовая, 69",
                    City = "Ростов-на-Дону",
                    Phone = "89642435611",
                    Email = "vladaleks@mail.ru",
                    Region = "Хабаровский край"
                };
                Employee emp4 = new Employee
                {
                    LastName = "Петров",
                    FirstName = "Юрий",
                    SecondName = "Яковлевич",
                    Title = "Водитель",
                    BirthDay = new DateTime(1989, 07, 11),
                    Address = "ул.Красная, 218",
                    City = "Москва",
                    Phone = "89264923566",
                    Email = "petrovdriver@mail.ru",
                    Region = "Приморский край"
                };
                // добавляем их в БД
                db.Employees.Add(emp1);
                db.Employees.Add(emp2);
                db.Employees.Add(emp3);
                db.Employees.Add(emp4);
                db.SaveChanges();


                Territory ter1 = new Territory { Discription = "Москва", Region = reg1 };
                Territory ter2 = new Territory { Discription = "Краснодар", Region = reg2 };
                Territory ter3 = new Territory { Discription = "Ростов-на-Дону", Region = reg3 };
                Territory ter4 = new Territory { Discription = "Ростов-на-Дону", Region = reg3 };
                db.Territories.Add(ter1);
                db.Territories.Add(ter2);
                db.Territories.Add(ter3);
                db.Territories.Add(ter4);
                db.SaveChanges();


                Employee_Territory emp_ter1 = new Employee_Territory { Employee = emp1, Territory = ter2 };
                Employee_Territory emp_ter2 = new Employee_Territory { Employee = emp2, Territory = ter2 };
                Employee_Territory emp_ter3 = new Employee_Territory { Employee = emp3, Territory = ter3 };
                Employee_Territory emp_ter4 = new Employee_Territory { Employee = emp1, Territory = ter1 };

                db.Employee_Territories.Add(emp_ter1);
                db.Employee_Territories.Add(emp_ter2);
                db.Employee_Territories.Add(emp_ter3);
                db.Employee_Territories.Add(emp_ter4);
                db.SaveChanges();

            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            initdb();
            textBlock.Text = "База данных создана. Объекты успешно сохранены. ";
        }

    }
    
}
