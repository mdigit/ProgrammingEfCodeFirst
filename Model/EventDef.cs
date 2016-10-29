using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingEfCodeFirst.Model
{
    public class EventDef
    {
        public Guid EventDefId { get; set; }
        public string Code { get; set; }

        [ForeignKey("ResetEvent")]
        public Guid? ResetDefId { get; set; }

        public virtual EventDef ResetEvent { get; set; }
    }
}
