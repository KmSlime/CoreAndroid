using TryHard.Models;
using Lib.Entity;
using Lib.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Lib_API.Entity;

namespace TryHard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductService productService;
        private ExerciseService exerciseService;
        private CourseService courseService;

        public HomeController(ILogger<HomeController> logger, 
            ProductService productService, ExerciseService exerciseService, CourseService courseService)
        {
            _logger = logger;
            this.productService = productService;
            this.exerciseService = exerciseService;
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            //List<Product> productList = productService.GetProducts();
            //List<Exercise> exercliseList = exerciseService.GetExercise();

            //Exercise ex = new Exercise();
            //ex.CourseId = 1;
            //ex.ExerciseId = Guid.NewGuid();
            //ex.ExerciseName = "Bài 10";
            //ex.ExerciseDay = "11 ngày";
            //ex.ExerciseTimePerRep = "5 rep / lần";
            //ex.Descript = "ko có";
            //ex.GifExercise = "K:\\projects\\C#\\CoreAndroid\\SmartFitnessAPI\\exercise_10.gif";
            //exerciseService.InsertExercise(ex);

            //Course c = new Course();
            //c.CourseName = "test";
            //c.CourseDay = "100 ngày";
            //c.CourseTimePerDays = "1h45 / ngayf";
            //c.Descript = "test tiếp";
            //c.GifCourse = "K:\\projects\\C#\\CoreAndroid\\SmartFitnessAPI\\banana.gif";
            //courseService.InsertCourse(c);


            //Product pd = new Product();
            //pd.Id = Guid.NewGuid();
            //pd.Name = "Sản phẩm 1";
            //pd.Price = "1000";
            //pd.Description = "Hello";
            //pd.Img = "123";
            //productService.InsertProduct(pd);

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
