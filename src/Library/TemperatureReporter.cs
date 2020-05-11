using System;

namespace Observer
{
    //Reacts to the updates that have been done to the subject
    public class TemperatureReporter : IObserver<Temperature>
    {
        private bool first;

        private Temperature last;
        
        private IObservable<Temperature> provider;

        public void StartReporting(IObservable<Temperature> provider)
        {
            this.provider = provider;
            this.first = true;
            this.provider.Subscribe(this);
        }

        public void StopReporting()
        {
            this.provider.Unsubscribe(this);
        }

        public void Update(Temperature Value)
        {
            Console.WriteLine($"The temperature is {Value.Degrees}°C at {Value.Date:g}");
            if (first)
            {
                
                //Temperature = Value
                last = Value;
                first = false;
            }
            else
            {
                Console.WriteLine($"   Change: {Value.Degrees - last.Degrees}° in " +
                    $"{Value.Date.ToUniversalTime() - last.Date.ToUniversalTime():g}");
            }
        }
    }
}