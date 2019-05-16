using ObserverPattern.Domain.DataTransferObject;
using ObserverPattern.Domain.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Application.Service.Interface
{
    public class FeederService : ISubject
    {
        private List<IObserver> observers;
        private Data data;

        public FeederService()
        {
            observers = new List<IObserver>();
        }

        public async Task AddObserverAsync(IObserver observer)
        {
            observers.Add(observer);
        }

        public async Task RemoveObserverAsync(IObserver observer)
        {
            observers.Remove(observer);
        }

        public async Task UpdateDataAsync(Data dataUpdate)
        {
            data = dataUpdate;
            await UpdateObserversAsync();
        }

        public async Task UpdateObserversAsync()
        {
            foreach (var observer in observers)
            {
                await observer.UpdateDataAsync(data);
            }
        }
    }
}
