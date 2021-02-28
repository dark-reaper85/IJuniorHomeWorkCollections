using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJunoirHomeWorkCollections
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            
            dictionary.Add("игра", "Занятие для развлечения, отдыха, укрепления здоровья и т.п. Какой-либо вид, способ такого занятия, основанный на определенных условиях, подчиненный определенным правилам.");
            dictionary.Add("игрок", "Участник какой-либо игры. Любитель играть в какую-либо игру, знаток какой-либо игры.");
            dictionary.Add("правила", "Собрание, свод положений, установок, определяющих порядок чего-либо");

            Console.WriteLine("Содержание словаря:\n");
            foreach (var wordKey in dictionary.Keys)
            {
                Console.WriteLine(wordKey);
            }
            
            Console.WriteLine("\nЗначение какого слова вы хотите узнать?");
            string userInput = Console.ReadLine();
            
            if (dictionary.ContainsKey(userInput))
            { 
                Console.WriteLine($"\nСлово \"{userInput}\" означает - \n{dictionary[userInput]}"); 
            }
            else
            {
                Console.WriteLine("Данное слово в словаре отсутствует");
            }
           
            Console.ReadLine();
        }
    }
}
