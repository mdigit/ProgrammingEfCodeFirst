using System;

namespace ProgrammingEfCodeFirst.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new BreakAwayDataService();
            service.InsertDestination();

            var eventService = new EventDataService();
            eventService.InsertEventDef();

            Console.WriteLine("Hit any key to terminate");
            Console.ReadKey();
        }
    }
}
