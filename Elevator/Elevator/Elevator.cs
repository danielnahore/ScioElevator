using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public class Elevator
    {
        private int currentFloor = 1; // Výchozí patro
        private SortedSet<int> requests = new SortedSet<int>(); // Požadavky na patra

        public void CallElevator(int floor)
        {
            if (floor < 1 || floor > 10)
            {
                Console.WriteLine("Chyba: Patro musí být mezi 1 a 10.");
                return;
            }
            requests.Add(floor);
            Console.WriteLine($"Výtah zavolán na patro {floor}.");
        }

        public void SelectDestination(int floor)
        {
            if (floor < 1 || floor > 10)
            {
                Console.WriteLine("Chyba: Patro musí být mezi 1 a 10.");
                return;
            }
            requests.Add(floor);
            Console.WriteLine($"Cíl nastaven na patro {floor}.");
        }

        public void OperateElevator()
        {
            while (requests.Count > 0)
            {
                int nextFloor = requests.First(); // Nejbližší požadované patro
                requests.Remove(nextFloor);

                Console.WriteLine($"Výtah se pohybuje z patra {currentFloor} do patra {nextFloor}.");
                currentFloor = nextFloor;
                Console.WriteLine($"Výtah dorazil na patro {currentFloor}.");
            }
            Console.WriteLine("Výtah dokončil všechny požadavky.");
        }
    }
}
