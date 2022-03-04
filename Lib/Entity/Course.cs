using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_API.Entity
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDay { get; set; }
        public string CourseTimePerDays { get; set; }
        public string Descript { get; set; }
        public int GifCourse { get; set; }


        public Course()
        {
        }

        public Course(int courseId, string courseName, string courseDay, string courseTimePerDays, string descript, int gifCourse)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseDay = courseDay;
            CourseTimePerDays = courseTimePerDays;
            Descript = descript;
            GifCourse = gifCourse;
        }
    }
}
