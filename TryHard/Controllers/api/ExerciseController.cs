using TryHard.Models;
using Lib.Entity;
using Lib.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib_API.Entity;

namespace TryHard.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : Controller
    {
    
        private ExerciseService exerciseService;
        public ExerciseController(ExerciseService exerciseService)
        {
            this.exerciseService = exerciseService;
        }
        

        [HttpGet("get-exercise")]
        //[Authorize(Roles = "Admin,Guest")]
        public async Task<ActionResult> GetExercise()
        {
            string UserLogin = HttpContext.User.Identity.Name;
            List<Exercise> exerciseList = exerciseService.GetExercise();
            return Ok(new { status = true, data = exerciseList });
        }
        [HttpPost("insert-exercise")]
        public async Task<ActionResult> InsertExercise(ExerciseModel exerciseModel)
        {
            try
            {
                Exercise ex = new Exercise();
                ex.CourseId = exerciseModel.CourseId;
                //ex.ExerciseId = exerciseModel.ExerciseId;
                ex.ExerciseName = exerciseModel.ExerciseName;
                ex.ExerciseDay = exerciseModel.ExerciseDay;
                ex.ExerciseTimePerRep = exerciseModel.ExerciseTimePerRep;
                ex.Descript = exerciseModel.Descript;
                ex.GifExercise = exerciseModel.GifExercise;
                exerciseService.InsertExercise(ex);
                return Ok(new { status = true, message = "Thành công" });
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }
    }
}
