using ObserverPattern.Domain.DataTransferObject;
using ObserverPattern.Domain.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Application.Service.Interface
{
    public class ObserverClass : IObserver
    {
        public async Task UpdateDataAsync(Data data)
        {
            Console.WriteLine($"{data.Date} - {data.Theme} - {data.Notice}");
        }
    }
}
