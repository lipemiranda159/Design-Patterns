using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Domain.Service.Interface
{
    public interface ISubject
    {
        Task AddObserverAsync(IObserver observer);
        Task RemoveObserverAsync(IObserver observer);
        Task UpdateObserversAsync();
    }
}
