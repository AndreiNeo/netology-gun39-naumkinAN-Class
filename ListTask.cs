using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class
{
    public class ListTask
    {
        private List<string> _listOfStrings;
        public ListTask() 
        {
            _listOfStrings = new List<string>();
        }

        public void DisplayList()
        {
            Console.WriteLine("Текущий список:");
            for (int i = 0; i < _listOfStrings.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_listOfStrings[i]}");
            }
        }
        public void TaskLoop()
        {
            _listOfStrings.Add ("Первый элемент");
            _listOfStrings.Add("Второй элемент");
            _listOfStrings.Add("Третий элемент");
            _listOfStrings.Add("Четвертый элемент");
            DisplayList();
            while (true) 
            {
                Console.WriteLine("\nВведите новую строку для добавления в список (для выхода введите exit)");
                string input = Console.ReadLine();
                if (input == "exit") 
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                _listOfStrings.Add(input);
                Console.WriteLine("Строка добавлена в список");
                DisplayList() ;
                Console.WriteLine("\nВведите новую строку для добавления в середину списка (для выхода введите exit)");
                input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                int midleIndex = _listOfStrings.Count / 2;
                _listOfStrings.Insert(midleIndex, input);
                Console.WriteLine("Строка добавлена в середину списка");
                DisplayList();
            }
        }
    }
}
