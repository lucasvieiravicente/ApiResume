using ApiResume.Domain.Context;
using ApiResume.Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiResume.Domain.Models
{
    public class Stack : EntityBase
    {
        public Stack() { }
        public Stack(string stackName, StackGroup stackId)
        {
            StackName = stackName;
            StackId = stackId;
        }

        [MaxLength(60)]
        public string StackName { get; set; }

        public StackGroup StackId { get; set; }

        public virtual IEnumerable<Knowledge> Knowledges { get; set; }
    }
}
