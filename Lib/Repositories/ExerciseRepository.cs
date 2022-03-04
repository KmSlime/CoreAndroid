using Lib.Data;
using Lib_API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IExerciseRepository : IRepository<Exercise>
    {
        List<Exercise> GetExercise();
    }
    public class ExerciseRepository : RepositoryBase<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public List<Exercise> GetExercise()
        {
            var query = _dbcontext.Exercise;
            return query.ToList();
        }
    }
}
