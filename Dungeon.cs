using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class
{
    public class Dungeon
    {
        private Room[] _rooms;
        public Dungeon()
        {
            _rooms = new Room[]
            {
                new Room(
                    new Unit("Рыцарь",7,30),
                    new Weapon("Меч", 10,40)
                    ),
                new Room(
                    new Unit("Вор",2,20),
                    new Weapon("Кинжал", 1,50)
                    ),
                new Room(
                    new Unit("Лучник",1,10),
                    new Weapon("Лук", 2,45)
                    ),

            };
        }
        public void ShowRooms()
        {
            for (int i = 0; i < _rooms.Length; i++) 
            {
                var room = _rooms[i];
                Console.WriteLine("Команта # " + (i + 1));
                Console.WriteLine("Юнит: " + room.Unit);
                Console.WriteLine("Оружие у него " + room.Weapon);
                Console.WriteLine("=========");

            } 
            }
    }
}
