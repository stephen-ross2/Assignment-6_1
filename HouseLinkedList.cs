using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_1
{
    internal class HouseLinkedList
    {
        private HouseNode head;

        public HouseLinkedList()
        {
            head = null;
        }

        public void AddHouse(int houseNumber, string address, string houseType)
        {
            HouseNode newHouse = new HouseNode(houseNumber, address, houseType);
            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                HouseNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newHouse;
            }
        }

        public HouseNode SearchHouse(int houseNumber)
        {
            HouseNode current = head;
            while (current != null)
            {
                if (current.HouseNumber == houseNumber)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void DisplayHouses()
        {
            if (head == null)
            {
                Console.WriteLine("No houses in the list.");
                return;
            }

            HouseNode current = head;
            while (current != null)
            {
                Console.WriteLine($"House Number: {current.HouseNumber}, Address: {current.Address}, Type: {current.HouseType}");
                current = current.Next;
            }
        }
    }
}

