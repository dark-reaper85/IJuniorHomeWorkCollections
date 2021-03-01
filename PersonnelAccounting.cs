using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccountingWithDictionary
{
    class PersonnelAccounting
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> files = new Dictionary<string, string>();
            files.Add("Болтендейл Крис", "вокалист");
            files.Add("Кунст Ханси", "вокалист");
            files.Add("Хэммет Кирк", "гитарист");

            bool isWorking = true;

            while (isWorking)
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Добавить досье");
                Console.WriteLine("2 - Вывести все досье");
                Console.WriteLine("3 - Удалить досье ");
                Console.WriteLine("4 - Выход");

                string choseMenu = Console.ReadLine();

                switch (choseMenu)
                {
                    case "1":
                        Console.WriteLine("Введите имя нового работника");
                        string addName = Console.ReadLine();
                        
                        if (CheckFiles(files, addName))
                        {
                            Console.WriteLine("Введите должность нового рабтника");
                            string addPost = Console.ReadLine();

                            Console.WriteLine("Новый работник добавлен");
                            files.Add(addName, addPost);
                        }
                        else
                        {
                            Console.WriteLine("Работник с таким именем уже есть в базе");
                        }

                        Console.ReadKey();
                        break;
                    case "2":
                        int i = 1;

                        foreach (var file in files)
                        {
                            Console.WriteLine($"{i}: {file.Key} - {file.Value}");
                            i++;
                        }

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Введите номер удаляемого досье");
                        int deletingFileNumber = Convert.ToInt32(Console.ReadLine());

                        DeleteFile(files, deletingFileNumber);

                        Console.ReadKey();
                        break;
                    case "4":
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        Console.ReadKey();
                        break;
                }
            }

        }
        static void DeleteFile( Dictionary<string,string> files ,int deletingFileNumber) 
        {
            if (deletingFileNumber > 0 && deletingFileNumber <= files.Count)
            {
                int j = 1;
                string deletingFile = null;

                foreach (var file in files)
                {
                    if (j == deletingFileNumber)
                    {
                        deletingFile = file.Key;
                        break;
                    }

                    j++;
                }

                files.Remove(deletingFile);
                Console.WriteLine($"Досье №{deletingFileNumber} удалено");
            }
            else
            {
                Console.WriteLine("Досье с таким номером отсутствует");
            }
        }
        static bool CheckFiles(Dictionary<string, string> files, string name) 
        {
            foreach (var file in files)
            {
                if (name == file.Key) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
