using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework_Class
{
    public class Weapon
    {
        public Interval DamageRange { get; private set; }

        private int _f = 1;

        public string Name { get; }
      
        public float Durability { get; } = 1f;

        public Weapon (string name) 
        
       {
            DamageRange = new Interval (1,10);
        }
        public Weapon(string name, int minDamage, int maxDamage) : this (name)
        {
          SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage,int maxDamage)
        {
            DamageRange = new Interval(minDamage,maxDamage);
        }
        public int GetDamage()
        {
            return (DamageRange.Min + DamageRange.Max) / 2;
        }
        public int RandomGetDamage()
        {
            return DamageRange.Get();
        }
    }
}
