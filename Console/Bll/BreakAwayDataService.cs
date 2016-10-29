using ProgrammingEfCodeFirst.Dal;
using ProgrammingEfCodeFirst.Model;

namespace ProgrammingEfCodeFirst.App
{
    public class BreakAwayDataService
    {
        public void InsertDestination()
        {
            var destination = new Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exquisite Bali",
                Name = "Bale"
            };

            using (var context = new BreakAwayContext())
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }
    }
}
