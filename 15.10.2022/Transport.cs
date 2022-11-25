using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Transport1
{
    public class Transport
    {
        string name { get; set; }   
        string type { get; set; }
        string number { get; set; }
        int run { get; set; }
        int route { get; set; }
        int tank { get; set; }
        bool mistakes;

        static int countoftransport;

        public Transport(string name, string type, string number, int run, int route, int tank, bool mistakes)
        {
            this.name = name;
            this.type = type;
            this.number = number;
            this.run = run;
            this.route = route;
            this.tank = tank;
            this.mistakes = mistakes;
        }

        public void AddingNewTransport(Transport newtransport)
        {
            Console.Write("Введите марку транспорта: ");
            this.name = Console.ReadLine();
            Console.Write("Введите вид траспорта: ");
            this.type = Console.ReadLine();
            Console.Write("Введите номер транспорта: ");
            this.number = Console.ReadLine();
            Console.Write("Введите прогон транспорта: ");
            this.run = int.Parse(Console.ReadLine());
            Console.Write("Введите маршрут траспорта: ");
            Console.Write("Наполненность бака: ");
            this.tank = int.Parse(Console.ReadLine());
            this.route = int.Parse(Console.ReadLine());
            Console.Write("Наличие опасных неисправностей (+,-): ");
            string boolmistakes = Console.ReadLine();
            switch(boolmistakes)
            {
                case "+":
                    this.mistakes = true;
                    break;
                case "-":
                    this.mistakes = false;
                    break;
                default:
                    this.mistakes= false;
                    break;
            }

            Console.WriteLine($"Марка: {this.name} вида {this.type}. Номер: {this.number}. Прогон: {this.run}. Маршрут №{this.route}.");

            countoftransport++;
        }
        
        public void FailureCheck(Transport transport)
        {
            if (transport.mistakes = true || transport.run > 20)
            {
                transport = null;
            }
        }

        public void FillingTank(Transport transport)
        {
            if (transport.tank < 10)
            {
                transport.tank = transport.tank + 10;
                Console.WriteLine($"В бак залито 10 литров. Наполненность бака: {transport.tank} литров");
            }
            else
            {
                Console.WriteLine("Нет нужды заправляться.");
            }

        }


        






    }
}
