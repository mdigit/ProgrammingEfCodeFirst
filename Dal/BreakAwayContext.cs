using ProgrammingEfCodeFirst.Model;
using System.Data.Entity;

namespace ProgrammingEfCodeFirst.Dal
{
    public class BreakAwayContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<EventDef> EventDefs { get; set; }
    }
}
