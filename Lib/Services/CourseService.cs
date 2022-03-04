using Lib.Entity;
using Lib.Repositories;
using Lib_API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Services
{
    public class CourseService
    {
        private ApplicationDbContext dbContext;
        private ICourseRepository courseRepository;

        public CourseService(ApplicationDbContext dbContext, ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
            this.dbContext = dbContext;
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void InsertCourse(Course c) {
            dbContext.Add(c);
            Save();
        }

        public List<Course> GetCourse()
        {
            return courseRepository.GetCourse();
        }
    }
}
