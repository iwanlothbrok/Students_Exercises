using System.Threading;

namespace TemperanceBar
{
   public abstract class BarmanThread
    {
        private Thread theThread;

        protected BarmanThread()
        {
            // TODO:
            // add code in the constructor so that an instance of the subclass is executed in a new thread 
          this.theThread = new Thread(Work);
        }

        // Thread methods / properties
        public void Start() => theThread.Start();
        public void Join() => theThread.Join();

        // Override in base class
        public abstract void Work();
    }
}
