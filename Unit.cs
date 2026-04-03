using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class
{
    public class Unit
    {
        private float _health;
        private float _armor;
        public string Name { get; }
        public float Health => _health;
        public Interval Damage { get; private set; }
        public float Armor => _armor = 0.6f;
        public Unit() : this(name: "Unknown Unit",0,5)
        {
        }
        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            _health = 100;
            Damage = new Interval(minDamage, maxDamage);
        }
        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }
        public bool SetDamage(float value)
        {
            _health = Health - value * Armor;
            if (Health <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
