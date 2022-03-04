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
    public class ExerciseService
    {
        private ApplicationDbContext dbContext;
        private IExerciseRepository exerciseRepository;

        public ExerciseService(ApplicationDbContext dbContext, IExerciseRepository exerciseRepository)
        {
            this.exerciseRepository = exerciseRepository;
            this.dbContext = dbContext;
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void InsertExercise(Exercise pd) {
            dbContext.Add(pd);
            Save();
        }

        public List<Exercise> GetExercise()
        {
            return exerciseRepository.GetExercise();
        }
    }
}
