using System.Data.Entity;
using ProgrammingEfCodeFirst.Domain;

namespace ProgrammingEfCodeFirst.Dal
{
    class VetContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
