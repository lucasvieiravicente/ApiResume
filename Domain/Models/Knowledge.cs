using ApiResume.Domain.Context;

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

        public string Title { get; set; }
        public string FirstDescription { get; set; }
        public string SecondDescription { get; set; }
        public string FilePathImage { get; set; }
    }
}
