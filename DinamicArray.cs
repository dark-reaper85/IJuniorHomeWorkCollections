using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArrayWithList
{
    class DinamicArray
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            List<int> numbers = new List<int>();
            int sum = 0;
            string userInput = null;
            
            while (isWorking)
            {
                Console.WriteLine("Введите целочисленное значение или sum для суммы введенных значений или exit для выхода:");
                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    isWorking = false;
                }
                else if (userInput == "sum")
                {
                    foreach (var number in numbers)
                    {
                        sum += number;
                    }

                    Console.WriteLine("Сумма введенных чисел равна: " + sum);
                    sum = 0;
                }
                else if (int.TryParse(userInput, out int value))
                {
                    numbers.Add(value);
                }
                else
                {
                    Console.WriteLine("Неизвестная команда");
                }
            }
        }
    }
}
