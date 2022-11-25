using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport1
{
    public class Route : Transport
    {
        public int name { get; set; }
        public int countofstations { get; set; }
        public int timebetweenstations { get; set; }    
        public Route(int name, int countofstations, int timebetweenstations)
        {
            this.name = name;
            this.countofstations = countofstations;
            this.timebetweenstations = timebetweenstations;
        }
        
        public static void AddingNewRoute()
        {
            var routes = new List<Route>();

            Console.Write("Количество объектов: ");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                Console.Write("Введите номер нового маршрута: ");
                int name1 = int.Parse(Console.ReadLine());
                
                Console.Write("Введите количество остановок без начальной: ");
                int countofstations1 = int.Parse(Console.ReadLine());
                
                Console.Write("Введите время между станциями (в минутах): ");
                int timebetweenstations1 = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"Новый маршрут: {name1} \r\nКоличество остановок: {countofstations1}\r\nВремя между станциями:  {timebetweenstations1} ");
                
                routes.Add(new Route(name1, countofstations1, timebetweenstations1));
            }   
        }
        
        public static void CountingTime()
        {
            Console.Write("Введите номер маршрута: ");
            int routenum = int.Parse(Console.ReadLine());
            Console.Write("Введите номер остановки, на которой вы находитесь: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите номер остановки, на которой вы хотите оказаться: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Ваш автобус по умолчанию стоит на конечке.");
            int timeto = number * route.timebetweenstations;
            int timeafter = (number1 - number) * route.timebetweenstations;
            Console.WriteLine($"Вам осталось ждать: {timeto}\r\nПотом вам осталось ехать: {timeafter}\r\nВсего время поездки составляет: {timeafter + timeto}");
            
        }
    }
}
