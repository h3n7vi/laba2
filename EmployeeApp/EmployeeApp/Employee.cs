using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //Поле данных
        private string empName;
        private int empID;
        private float currPay;
        // Метод доступа (метод get)
        public string GetName()
        {
            return empName;
        }
        // методы изменения (метод set)
        public void SetName(string name)
        {
            //перед присваиванием проверить входное значение
            if (name.Length > 15)
                // ошибка имя должно иметь меньше 16 символов
                Console.WriteLine("Error! Name must be less than 16 characters!");
            else
                empName = name;
        }
        //Конструкторы
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }
        //Методы
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name : {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
