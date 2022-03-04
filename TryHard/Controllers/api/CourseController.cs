using Lib.Services;
using Lib_API.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TryHard.Models;

namespace TryHard.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {

        private CourseService courseService;
        public CourseController(CourseService courseService)
        {
            this.courseService = courseService;
        }


        [HttpGet("get-course")]
        //[Authorize(Roles = "Admin,Guest")]
        public async Task<ActionResult> GetCourse()
        {
            string UserLogin = HttpContext.User.Identity.Name;
            List<Course> exerciseList = courseService.GetCourse();
            return Ok(new { status = true, data = exerciseList });
        }

        [HttpPost("insert-course")]
        public ActionResult InsertCourse(CourseModel courseModel)
        {
            try
            {

                Course c = new Course();
                c.CourseName = courseModel.CourseName;
                c.CourseDay = courseModel.CourseDay;
                c.CourseTimePerDays = courseModel.CourseTimePerDays;
                c.Descript = courseModel.Descript;
                c.GifCourse = courseModel.GifCourse;
                courseService.InsertCourse(c);
                return Ok(new { status = true, message = "Thành công" });
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
