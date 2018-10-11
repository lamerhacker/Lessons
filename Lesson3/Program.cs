using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository();
            //код с 15 по 38 строчку включительно сделан для того чтоб заполнять джейсон не ручками, а через c# , в дальнейшем просто комментим их
           //Item new_item = new Item
            //{
              //  Description = "such product much wow",
               // Name = "Product"
            //};
            //rep.Items = new List<Item>(); //когда в джейсоне пусто, дабы обойти ошибку, делаем так
            //rep.Items.Add(new_item);
           // Supplyer new_supplyer = new Supplyer
           // {
           //     Name = "postavshik",
           //     Adress = "Ulica Pushkina Dom Kolotushkina"
           // };
           // rep.Supplyers = new List<Supplyer>();
           // rep.Supplyers.Add(new_supplyer);
           // rep.Orders = new List<Order>();
           // rep.Orders.Add(new Order
           // {
           //     Supplyer = new_supplyer,
           //     Item = new_item,
           //     Count = 2,
           //     Price = 70.30M,
           //     Date = DateTime.Now
           // });
           // rep.Save();
            Console.WriteLine("Programm is finished!");
            //Console.ReadLine();
            do
            {
                int year;
                int month;
                bool result_year;
                bool result_month;
                do
                {
                    Console.WriteLine("Введите год");
                    result_year = int.TryParse(Console.ReadLine(), out year); // если ввели не инт - то выдает false 
                } while (!result_year);
                do
                {
                    Console.WriteLine("Введите месяц");
                    result_month = int.TryParse(Console.ReadLine(), out month); // если ввели не инт - то выдает false 
                } while ((!result_month) && (month > 13) && (month < 1));

                decimal sum = 0;
                foreach (var order in rep.Orders)
                {
                    if ((order.Date.Month == month) && (order.Date.Year == year))
                    {
                        sum += (order.Price * order.Count);
                    }
                }
                Console.Write("Сумма заказов состовляет: {0} ", sum);
                Console.WriteLine("Нажмите любую клавшу для повторного запуска или напишите stop для остановки");
            } while (Console.ReadLine().ToLower() != "stop");
        }
    }
}
