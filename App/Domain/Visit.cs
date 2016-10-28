using System;

namespace ProgrammingEfCodeFirst.Domain
{
    class Visit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ReasonForVisit { get; set; }
        public string Outcome { get; set; }
        public Decimal Weight { get; set; }
        public int PatientId { get; set; }
    }
}
