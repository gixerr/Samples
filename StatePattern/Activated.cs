using System;

namespace StatePattern
{
    public class Activated : IComputerState
    {
        public Activated()
        {
            Computer.StateName = GetType().Name;
        }
        public IComputerState Hibernate()
            => new Hibernated();

        public IComputerState KillProcess(Action removeFromProcesses)
        {
            removeFromProcesses();
            return this;
        }

        public IComputerState RunProcess(Action addToProcesses)
        {
            addToProcesses();
            return this;
        }

        public IComputerState ShutDown()
            => new ShutedDown();

        public IComputerState Activate()
            => this;
    }

}