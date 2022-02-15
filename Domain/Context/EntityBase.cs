using System;
using System.ComponentModel.DataAnnotations;

namespace ApiResume.Domain.Context
{
    public class EntityBase
    {
        [MaxLength(50)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public bool FlagActive { get; set; } = true;
    }
}
