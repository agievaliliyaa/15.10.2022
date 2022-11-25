using Transport1;
using System;
using Transport1;


namespace Homework
{ 
class Shit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Впишите свою позицию (клиент, работник обслуживания, работник автопарка): ");
            string typeofuser = Console.ReadLine();
            switch(typeofuser)
            {
                case "клиент":
                    Clients mainclient = new Clients("Bob", "Brown", 18, 13, 2900, "Russia");
                    Console.WriteLine("Введите \r\nрегистрация : если хотите зарегистрироваться\r\nбилет : если хотите приобрести билет(доступно после регистрации)\r\nвернутьбилет : если хотите вернуть билет(доступно после регистрации)\r\nльгота : если хотите узнать о скидках для льготный категорий клиентов\r\nкинутьсяподавтобус : если хотите умереть");
                    string actioncl = Console.ReadLine();
                    switch (actioncl)
                    {
                        case "регистрация":
                            Clients.AddingNewClient(); 
                            break;
                        case "билет":
                            Clients.BuyingTicket(mainclient);
                            break;
                        case "вернутьбилет":
                            Clients.ReturningTicket(mainclient);
                            break;
                        case "льгота":
                            Clients.SalesForClient();
                            break;
                        case "кинутьсяподавтобус":
                            Clients.DeadInside(mainclient);
                            break;
                        default:
                            Console.WriteLine("Вы ввели что-то не то");
                            break;
                    }
                    break;
                case "работник обслуживания":
                    Console.WriteLine("Введите \r\nрегистрация : если хотите зарегестрировать нового клиента \r\nрегистрацияклиента : если хотите зарегестрировать нового клиента\r\nпродажабилета : если хотите продать билет\r\nвозвратбилета : если хотите осуществить возврат билета для клиента \r\nскидки : если хотите рассказать клиенту о скидках ");
                    string blabal = Console.ReadLine();
                    Employees newemployee = new Employees();
                    switch (blabal)
                        {
                        case "регистрация":
                            Employees.RegistrationOfNewEmployee(newemployee);
                            break;
                        case "регстрацияклиента":
                            Employees.AddingNewClientByEmployee(newemployee);
                            break;
                        case "продажабилета":
                            Employees.SellingTickets(newemployee);
                            break;
                        case "возвратбилета":
                            Employees.ReturningTicketsByEmployee(newemployee);
                            break;
                        case "скидки":
                            Employees.SalesForClientByEmployee(newemployee);
                            break;
                        default:
                            Console.WriteLine("Вы ввели что-то не то");
                            break;

                    }
                    break;
                case "работник автопарка":
                    break;
                default: 
                    Console.WriteLine("вы ввели что-то не то");
                    break;
            }
            
        }
}
}


