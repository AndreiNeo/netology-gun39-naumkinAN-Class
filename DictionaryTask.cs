using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class
{
    public class DictionaryTask
    {
        private Dictionary<string, int> _studentGrades;
        public DictionaryTask()
        {
            _studentGrades = new Dictionary<string, int>();
        }
        public void TaskLoop()
        {
            while (true)
            {
                Console.WriteLine("Введите имя студента для добавления в список оценок или exit для выхода");
                string inputName = Console.ReadLine();
                if(inputName == "exit")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                Console.WriteLine("Введите оценку этого студента от 2 до 5 или exit для выхода");
                string inputGrade = Console.ReadLine();
                if (inputName == "exit")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                if (int.TryParse(inputGrade, out int grade))
                {
                    if (grade >= 2 && grade <= 5)
                    {
                        _studentGrades[inputName] = grade;
                        Console.WriteLine($"Студент {inputName} добавлен с оценкой {grade}");
                    }
                    else 
                    {
                        Console.WriteLine("Ошибка! Оценка должна быть от 2 до 5!");
                    }

                }
                else
                {
                    Console.WriteLine("Ошибка! Невереный формат оценки!");
                }
                Console.WriteLine("\nВведите имя студента для поиска его оценки или exit для выхода");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                if (_studentGrades.ContainsKey(input))
                {
                    Console.WriteLine($"Студент {input} имеет среднюю оценку: {_studentGrades[input]}");
                }
                else 
                {
                    Console.WriteLine($"Студент с именем {input} в списке не числится");
                }

            }
        }
    }
}
