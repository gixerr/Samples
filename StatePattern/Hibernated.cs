using System;

namespace StatePattern
{
    public class Hibernated : IComputerState
    {
        public Hibernated()
        {
            Computer.StateName = GetType().Name;
        }
        public IComputerState Activate()
            => new Activated();

        public IComputerState RunProcess(Action addToProcesses)
        {
            addToProcesses();
            return new Activated();
        }

        public IComputerState KillProcess(Action removeFromProcesses)
            => this;

        public IComputerState ShutDown()
            => this;
        

        public IComputerState Hibernate()
            => this;
    }
}