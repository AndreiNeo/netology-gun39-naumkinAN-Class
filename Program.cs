namespace Homework_Class
{

    public struct Interval
    {
        Random _random = new Random();

        public int Min { get; private set; }
        public int Max { get; private set; }

        public Interval(int minValue, int maxValue) : this()
        {
            int min = minValue;
            int max = maxValue;

            if (min > max)
            {
                Console.WriteLine("Минимальное значение больше макисмального, поменяли местами");
                int temp = min;
                min = max;
                max = temp;
            }
            if (min < 0)
            {
                Console.WriteLine("Минимальное занчение  не может быть меньше нуля, установлено значение 0");
                min = 0;
            }
            if (max < 0)
            {
                Console.WriteLine("Макисмальное занчение  не может быть меньше нуля, установлено значение 0");
                max = 0;
            }
            if (min == max)
            {
                Console.WriteLine("Максимальное значение равно минимальному, установлено 10");
                max = 10;
            }
            Min = min;
            Max = max;
        }
        public int Get()
        {
            return _random.Next(Min, Max);
        }
    }

    public struct Room
    {
        public Unit Unit { get; }
        public Weapon Weapon { get; }
        public Room(Unit unit, Weapon weapon) 
        {
            Unit = unit;
            Weapon = weapon;
        }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();
        }
    }
}
