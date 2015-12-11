using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Observer
{
    /// <summary>
    /// The 'Subject' interface
    /// </summary>
    public interface IPublisher
    {
        void Subscribe(IObserver observer);       // The 'Attch()' operation
        void UnSubscribe(IObserver observer);     // The 'Detach()' operation
        void Notify();                            // call the observer to update itself
    }
}