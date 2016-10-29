using ProgrammingEfCodeFirst.Dal;
using ProgrammingEfCodeFirst.Model;

namespace ProgrammingEfCodeFirst.App
{
    public class EventDataService
    {
        public void InsertEventDef()
        {
            using (var context = new BreakAwayContext())
            {
                var resetEvent = new EventDef
                {
                    Code = "6000",
                };
                var eventDef = new EventDef
                {
                    Code = "5000",
                    ResetEvent = resetEvent
                };
                context.EventDefs.Add(resetEvent);
                context.EventDefs.Add(eventDef);
                context.SaveChanges();
            }
        }
    }
}
