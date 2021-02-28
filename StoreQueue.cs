using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueInTheStore
{
    class StoreQueue
    {
        static void Main(string[] args)
        {
            int storeBalance = 0;

            Queue<int> purchases = new Queue<int>();
            purchases.Enqueue(100);
            purchases.Enqueue(1356);
            purchases.Enqueue(142);
            purchases.Enqueue(2532);
            purchases.Enqueue(5654);

            while (purchases.Count > 0)
            {
                Console.Clear();

                Console.WriteLine("Обслужить нового покупателя?");
                Console.ReadKey();
                
                Console.WriteLine($"Совершена покупка на сумму: {purchases.Peek()}");

                storeBalance += purchases.Dequeue();
                Console.WriteLine($"Баланс магазина = {storeBalance}");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Все покупатели обслужены. Очередь пуста.");
            Console.WriteLine($"Баланс магазина = {storeBalance}");
            Console.ReadKey();
        }
    }
}
