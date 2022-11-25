using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Transport1
{
    
    public class Clients
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int countoftickets { get; set; }
        public double money { get; set; }
        public string citizenship { get; set; }

        public Clients(string name, string surname, int age, int countoftickets, double money, string citizenship)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.countoftickets = countoftickets;
            this.money = money;
            this.citizenship = citizenship;
        }
        public Clients() { }



        static int clientscount { get; set; }
        

        public static void AddingNewClient()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите гражданство: ");
            string citizenship = Console.ReadLine();
            Console.Write("Введите бюджет: ");
            double money = double.Parse(Console.ReadLine());
            int countoftickets = 0;
            Clients someclient = new Clients(name, surname, age, countoftickets, money, citizenship);

            clientscount++;

            Console.Write($"{someclient.name} {someclient.surname}, {someclient.age} лет. Страна гражданства: {someclient.citizenship}. Бюджет: {someclient.money}");
            
        }
        
        public static void BuyingTicket(Clients someclient)
        {
            Console.Write("\r\nВведите желаемый билет: ");
            string blabla = Console.ReadLine();
            Console.Write("\r\nЦена билета: ");
            double ticketprice = int.Parse(Console.ReadLine());
            Console.Write("\r\nВведите количество билетов: ");
            double ticketcount = int.Parse(Console.ReadLine());
            Console.Write("\r\nВведите процент скидки: ");
            double ticketsale = int.Parse(Console.ReadLine());
            double finalprice = ticketprice * ticketcount - (ticketsale / 100) * ticketcount * ticketprice;
            Console.WriteLine($"\r\nСтоимость с учетом скидки и количества билетов: {finalprice} рублей");

            double property = someclient.money - finalprice;
            if (property < 0)
            {
                Console.WriteLine("\r\nНедостаточно средств.");
            }
            else
            {
                Console.WriteLine("Оплата прошла успешно.");
                someclient.money = someclient.money - finalprice;
                someclient.countoftickets++;
            }
             
                 
        }

        public static void ReturningTicket(Clients someclient)
        {
            if (someclient.countoftickets < 0)
            {
                Console.WriteLine("У вас нет билетов для возвращения.");
            }
            else
            {
                Console.Write("Введите количество часов до начала поездки: ");
                int hoursdrive = int.Parse(Console.ReadLine());
                if (hoursdrive < 24)
                {
                    Console.WriteLine("Вы не можете вернуть билет, т.к. истек срок возвращения.");
                }
                else
                {
                    Console.Write("Введите сумму, внесенную за билет: ");
                    double deadprice = double.Parse(Console.ReadLine());
                    deadprice = deadprice / 2;
                    someclient.money = someclient.money + deadprice;
                    Console.WriteLine($"Вам возвращена половина цены за билет, а именно: {deadprice}");
                }
            }
        }

        public static void SalesForClient()
        {
            Console.WriteLine("Относитесь ли вы к льготной категории?");
            string answer1 = Console.ReadLine();
            if (answer1 == "да")
            {
                Console.WriteLine("К какой льготной категории вы относитесь? (инвалид, пенсионер, студент, школьник, ветеран ВОВ");
                string categories = Console.ReadLine();
                switch(categories)
                {
                    case "инвалид":
                        Console.WriteLine($"Процент вашей скидки составляет 10 единиц");
                        break;
                    case "ветеран ВОВ":
                        Console.WriteLine($"Процент вашей скидки составляет 15 единиц");
                        break;
                    case "школьник":
                        Console.WriteLine($"Процент вашей скидки составляет 20 единиц");
                        break;
                    case "студент":
                        Console.WriteLine($"Процент вашей скидки составляет 25 единиц");
                        break;
                    case "пенсионер":
                        Console.WriteLine($"Процент вашей скидки составляет 30 единиц");
                        break;
                    default:
                        Console.WriteLine("Вы ввели что-то не то...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Для вас скидок нет!");
            }

        }
        public static void DeadInside(Clients someclient)
        {
            Console.WriteLine("Прошу, не делайте этого!");
            Console.ReadKey();
            someclient = null;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
        }

        


    }
}
