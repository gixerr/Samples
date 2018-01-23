namespace StatePattern
{
    public class Computer
    {
        public short ProcessesCount { get; protected set; }
        
        private IComputerState State { get; set; }

        public static string StateName { get; set; }

        public Computer()
        {
            this.State = new ShutedDown();
        }

        public void RunProcess()
            => this.State = this.State.RunProcess(() => this.ProcessesCount++);

        public void KillProcess()
            => this.State = this.State.KillProcess(() => this.ProcessesCount--);

        public void TurnOff()
            {
                ProcessesCount = 0;
                this.State = this.State.ShutDown();
            }

        public void Hibernate()
            => this.State = this.State.Hibernate();

        public void Activate()
            => this.State = this.State.Activate();

    }
}