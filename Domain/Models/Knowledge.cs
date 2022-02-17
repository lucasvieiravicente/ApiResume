using ApiResume.Domain.Context;
using ApiResume.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ApiResume.Domain.Models
{
    public class Knowledge : EntityBase
    {
        public Knowledge()
        {
        }

        public Knowledge(string title, string firstDescription, string secondDescription, string filePathImage)
        {
            Title = title;
            FirstDescription = firstDescription;
            SecondDescription = secondDescription;
            FilePathImage = filePathImage;
        }

        [MaxLength(25)]
        public string Title { get; set; }
        
        [MaxLength(500)]
        public string FirstDescription { get; set; }

        [MaxLength(500)]
        public string SecondDescription { get; set; }

        [MaxLength(500)]
        public string FilePathImage { get; set; }

        public StackGroup StackId { get; set; }

        public virtual Stack Stack { get; set; }
    }
}
