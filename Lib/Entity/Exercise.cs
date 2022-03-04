using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_API.Entity
{
    public class Exercise
    {

        public Exercise() { }
    
        public Exercise(int courseId, int exerciseId, string exerciseName, string exerciseDay, 
            string exerciseTimePerRep, string descript, string gifExercise)
        {
            this.CourseId = courseId;
            ExerciseId = exerciseId;
            ExerciseName = exerciseName;
            ExerciseDay = exerciseDay;
            ExerciseTimePerRep = exerciseTimePerRep;
            Descript = descript;
            GifExercise = gifExercise;
        }

        public int CourseId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDay { get; set; }

        public string ExerciseTimePerRep { get; set; }
        public string Descript { get; set; }

        public string GifExercise { get; set; }
    }
}
