using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class Course: BaseEntity
    {

        public enum Level
        {
            Basic,
            Medium,
            Advance,
            Expert
        }

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public Level level { get; set; } = Level.Basic;
        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
        [Required]
        public Chapter Chapter{ get; set; } = new Chapter();
    

    }
}
