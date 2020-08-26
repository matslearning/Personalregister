using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
            bool active = true;
            while(active)
            {
                Console.Clear();
                staff.DisplayStaff();
                Console.Write("Namn på anställd (ENTER för att avsluta): ");
                string nameInput = Console.ReadLine();
                if(nameInput != "")
                {
                    Console.Write("Lön för {0}: ", nameInput);
                    string salaryInput = Console.ReadLine();
                    try
                    {
                        double salary = double.Parse(salaryInput);
                        Employee emp = new Employee();
                        emp.Name = nameInput;
                        emp.Salary = salary;
                        staff.AddOrUpdateEmployee(emp);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Kunde inte förstå den lönen. Tryck en tangent för att fortsätta!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Ok. Sessionen avslutad. För att i framtiden kunna spara registret - köp gärna vår kommande databasmodul! :-)");
                    active = false;
                }
            }
        }
    }
}
