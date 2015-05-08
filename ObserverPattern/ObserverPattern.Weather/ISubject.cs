using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Weather
{
    public interface ISubject
    {
        void RegisterSubscriber(ISubscriber subc);
        void RemoveSubscriber(ISubscriber subc);
        void NotifySubscribers();
    }
}
