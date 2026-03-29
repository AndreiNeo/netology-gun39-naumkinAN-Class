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
        public int Damage { get; } = 5;
        public float Armor => _armor = 0.6f;
        public Unit() : this(name: "Unknown Unit")
        {
        }
        public Unit(string name)
        {
            Name = name;
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
