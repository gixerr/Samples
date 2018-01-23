using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nStarting computer...");
            computer.Activate();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nAdding process...");
            computer.RunProcess();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nAdding another process...");
            computer.RunProcess();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nKilling 1 process...");
            computer.KillProcess();
            PrintCurrentComputerState(computer);
            
            System.Console.WriteLine("\nHibernating computer...");
            computer.Hibernate();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nAdding process to hibernated computer. It should activate computer...");
            computer.RunProcess();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nShutting down computer...");
            computer.TurnOff();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nTrying to add process to shuted down computer. It should change nothing...");
            computer.RunProcess();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nTrying to hibernate shuted down computer. It should change nothing...");
            computer.Hibernate();
            PrintCurrentComputerState(computer);

            System.Console.WriteLine("\nStarting computer...");
            computer.Activate();
            PrintCurrentComputerState(computer);
        }

        static void PrintCurrentComputerState(Computer computer)
            => System.Console.WriteLine($"Computer is in '{Computer.StateName}' state and have {computer.ProcessesCount} running processes.");
    }
}
