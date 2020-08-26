using System;
using System.Collections.Generic;
using System.Text;

namespace Personalregister
{
    class Staff
    {
        public Staff()
        {
            staff = new List<Employee>();
        }

        private List<Employee> staff;

        public void AddOrUpdateEmployee(Employee employee)
        {
            var existingEmployee = NameExists(employee.Name);
            if (existingEmployee == null)
            {
                staff.Add(employee);
            }
            else
            {
                existingEmployee.Salary = employee.Salary;
            }
        }
        public void DisplayStaff()
        {
            Console.WriteLine("Lista över anställda på Gittans Restaurang");
            Console.WriteLine("------------------------------------------");
            if (staff.Count > 0)
            {
                Console.WriteLine("Anställd             Lön");
                foreach (Employee emp in staff)
                {
                    Console.WriteLine(emp.Name.PadRight(21, ' ') + emp.Salary);
                }
            }
            else
            {
                Console.WriteLine("Just nu saknar företaget personal. ");
            }
            Console.WriteLine();
        }

        private Employee NameExists(string name)
        {
            foreach(Employee emp in staff)
            {
                if (emp.Name.ToLower() == name.ToLower())
                {
                    return emp; //returnera personen som har detta namn
                }
            }
            return null;
        }
    }
}
