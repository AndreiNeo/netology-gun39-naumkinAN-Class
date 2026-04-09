using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class
{
    internal class LinkedListTask
    {
        private class Node
        {
            public string Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(string data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }

        private class DoublyLinkedList
        {
            private Node _head;
            private Node _tail;

            public void AddLast(string data)
            {
                Node newNode = new Node(data);
                if (_head == null)
                {
                    _head = newNode;
                    _tail = newNode;
                }
                else
                {
                    _tail.Next = newNode;
                    newNode.Previous = _tail;
                    _tail = newNode;
                }
            }

            public void DisplayForward()
            {
                if (_head == null)
                {
                    Console.WriteLine("Список пуст.");
                    return;
                }

                Node current = _head;
                while (current != null)
                {
                    Console.Write(current.Data);
                    if (current.Next != null)
                        Console.Write(" <-> ");
                    current = current.Next;
                }
                Console.WriteLine();
            }

            public void DisplayBackward()
            {
                if (_tail == null)
                {
                    Console.WriteLine("Список пуст.");
                    return;
                }

                Node current = _tail;
                while (current != null)
                {
                    Console.Write(current.Data);
                    if (current.Previous != null)
                        Console.Write(" <-> ");
                    current = current.Previous;
                }
                Console.WriteLine();
            }
        }

        public void TaskLoop()
        {
            DoublyLinkedList list = new DoublyLinkedList();
            Console.WriteLine("Создайте список из 4 элементов или введите exit для выхода");
            int elementCount = 0;
            while (elementCount < 4)
            {
             string input = Console.ReadLine();
            if(input == "exit")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
            list.AddLast(input);
                elementCount++;
            }
            Console.WriteLine("\n Создан список из 4 элементов");
            Console.WriteLine("Прямой порядок");
            list.DisplayForward();
            Console.WriteLine("\n Обратный порядок");
            list.DisplayBackward();

        }
    }
}
