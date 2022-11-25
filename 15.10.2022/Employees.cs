using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Transport1
{
    public class Employees : Clients
    {
       
        public string employeetype { get; set; }
        public static int countofclients1{ get; set; }

        public static int employeescount;

       
        public Employees(string employeetype, int countofclients1)
        {
            
            this.employeetype = employeetype;
            

        }
        public Employees() { }

        public Clients mainclient = new Clients("Bob", "Brown", 18, 13, 2900, "Russia");
        public static void RegistrationOfNewEmployee(Employees newemployee)
        {

            Console.Write("Введите имя: ");
            newemployee.name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            newemployee.surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            newemployee.age = int.Parse(Console.ReadLine());
            Console.Write("Введите должность: ");
            newemployee.employeetype = Console.ReadLine();

            employeescount++;

            Console.Write($"Работник: {newemployee.name} {newemployee.surname}, {newemployee.age} лет. Должность: {newemployee.employeetype}");
        }

        public static void AddingNewClientByEmployee(Employees someemployee)
        {
            Console.WriteLine($"Обслуживающий работник: {someemployee.name} {someemployee.surname}");
            AddingNewClient();
            countofclients1++;
        }

        public static void SellingTickets(Employees someemployee)
        {
            Console.WriteLine($"Обслуживающий работник: {someemployee.name} {someemployee.surname}");
            BuyingTicket(someemployee);
            countofclients1++;
        }
        public static void ReturningTicketsByEmployee(Employees someemployee)
        {
            Console.WriteLine($"Обслуживающий работник: {someemployee.name} {someemployee.surname}");
            ReturningTicket(someemployee);
            countofclients1++;
        }
       public static void SalesForClientByEmployee(Employees someemployee)
        {
            Console.WriteLine($"Обслуживающий работник: {someemployee.name} {someemployee.surname}");
            SalesForClient();
            countofclients1++;
        }

        
        
        
    }
}
