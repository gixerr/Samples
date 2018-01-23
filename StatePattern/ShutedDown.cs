using System;

namespace StatePattern
{
    public class ShutedDown : IComputerState
    {
        public ShutedDown()
        {
            Computer.StateName = GetType().Name;
        }
        
        public IComputerState Activate()
            => new Activated();

        public IComputerState Hibernate()
            => this;

        public IComputerState RunProcess(Action addToProcesses)
            => this;

        public IComputerState KillProcess(Action removeFromProcesses)
            => this;

        public IComputerState ShutDown()
            => this;
    }
}