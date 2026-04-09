using Homework_Class;

namespace Homework_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите цифру 1, 2, или 3 для выбора задачи");
                Console.WriteLine("Или exit для выхода из программы");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }
                if (int.TryParse(input, out int task))
                {
                    switch (task)
                    {
                        case 1:
                            CheckTaskFirst();
                            break;
                        case 2:
                            CheckTaskSecond();
                            break;
                        case 3:
                            CheckTaskThird();
                            break;
                        default:
                            Console.WriteLine("Неверный номер задачи. Ведите 1,2 или 3");
                            break;
                    }
                }
            }
        }
            private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }
        private static void CheckTaskSecond()
        {
            var dictionaryTask = new DictionaryTask();
            dictionaryTask.TaskLoop();
        }
        private static void CheckTaskThird()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}

