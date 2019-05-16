using ObserverPattern.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Domain.Service.Interface
{
    public interface IObserver
    {
        Task UpdateDataAsync(Data data);
    }
}
