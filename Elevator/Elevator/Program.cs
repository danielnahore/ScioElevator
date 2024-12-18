﻿namespace Elevator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
    
            // Simulace požadavků
            elevator.CallElevator(5); // Výtah zavolán na patro 5
            elevator.SelectDestination(8); // Uživatel chce jet do patra 8
            elevator.OperateElevator(); // Spustí výtah
    
            // Další požadavky
            elevator.CallElevator(3); // Výtah zavolán na patro 3
            elevator.SelectDestination(10); // Uživatel chce jet do patra 10
            elevator.OperateElevator(); // Spustí výtah
        }
    }
}
