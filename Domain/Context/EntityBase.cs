using System;

namespace ApiResume.Domain.Context
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public bool FlagActive { get; set; }
    }
}
