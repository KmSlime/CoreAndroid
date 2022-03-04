using Lib.Data;
using Lib_API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{ 
    public interface ICourseRepository : IRepository<Course>
    {
        List<Course> GetCourse();
    }
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public List<Course> GetCourse()
        {
            var query = _dbcontext.Course;
            return query.ToList();
        }
    }
}
