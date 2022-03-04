using Lib.Data;
using Lib.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        List<ApplicationUser> GetApplicationUser();
    }
    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public List<ApplicationUser> GetApplicationUser()
        {
            var query = _dbcontext.ApplicationUser;
            return query.ToList();
        }
    }
}
