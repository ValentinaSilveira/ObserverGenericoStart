using System;
using System.Collections.Generic;

namespace Observer
{
    public interface IObserver<T>
    {
        //Receive an update of the type object T(Temperature)
        void Update(T Value);
    }
}