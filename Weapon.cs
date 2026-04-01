using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework_Class
{
    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private int _f = 1;


        public string Name { get; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public float Durability { get; } = 1;

        public Weapon (string name)
        {
            Name = name;
        }
        public Weapon() {
        Name = "Unknown weapon";
        }
        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
          SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage,int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                Console.WriteLine("Для оружия " + this.Name + " поменяли местами минимальное и макисмальное значение урона");
                int temp = minDamage;
                minDamage = maxDamage;
                maxDamage = temp;
            }
            if (minDamage < 1)
            {
                minDamage = _f;
                Console.WriteLine("Минимальное значение урона не может быть меньше " + _f + ", значение минимально урона теперь " + _f);
            }
            if (maxDamage < 1)
            {
                Console.WriteLine("Максимальное значение урона не может быть равен или меньше " + _f + ", значение максимального урона теперь " + 10);
                maxDamage = 10;
            }
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        public int GetDamage()
        {
            return (_minDamage + _maxDamage) / 2;
        }
    }
}
