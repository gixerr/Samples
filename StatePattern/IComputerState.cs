using System;

namespace StatePattern
{
    public interface IComputerState
    {
        IComputerState RunProcess(Action addToProcesses);
        IComputerState KillProcess(Action removeFromProcesses);
        IComputerState Activate();
        IComputerState ShutDown();
        IComputerState Hibernate();
    }
}