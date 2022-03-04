using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TryHard.Models
{
    public class CourseModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDay { get; set; }

        public string CourseTimePerDays { get; set; }
        public string Descript { get; set; }

        public int GifCourse { get; set; }


    }
}
