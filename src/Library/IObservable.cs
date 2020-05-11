using System;
using System.Collections.Generic;


namespace Observer
{
    public interface IObservable<T>
    {
        //Add observer
        void Subscribe(IObserver<T> observer);
        
        //Eliminate observer
        void Unsubscribe(IObserver<T> observer);
    }
}