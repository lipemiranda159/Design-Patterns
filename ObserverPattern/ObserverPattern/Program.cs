using ObserverPattern.Application.Service.Interface;
using ObserverPattern.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var Subject = new FeederService();

            var user = new ObserverClass();

            Subject.AddObserverAsync(user).Wait();

            Subject.UpdateDataAsync(new Data()
            {
                Date = DateTime.Now,
                Notice = "Learning new things it's a good thing to do!",
                Theme = "Learning patterns"
            }).Wait();

            Console.ReadLine();
        }
    }
}
