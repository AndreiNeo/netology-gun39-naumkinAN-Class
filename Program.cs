namespace Homework_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weapon = new Weapon();
            Console.WriteLine(weapon.Name);
            var weapon1 = new Weapon("AK47", -2,-7);
           Console.WriteLine();
        }
    }
}
