using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingEfCodeFirst.Model
{
    public class EventDef
    {
        public int EventDefId { get; set; }
        public string Code { get; set; }
        public int? ResetEventId { get; set; }
        [ForeignKey("ResetEventId")]
        public virtual EventDef ResetEvent { get; set; }
    }
}
