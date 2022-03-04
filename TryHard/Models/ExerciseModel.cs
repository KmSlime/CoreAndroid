using Lib_API.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace TryHard.Models
{
    public class ExerciseModel
    {

        public int CourseId { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseDay { get; set; }

        public string ExerciseTimePerRep { get; set; }
        public string Descript { get; set; }

        public string GifExercise { get; set; }

    }
}
