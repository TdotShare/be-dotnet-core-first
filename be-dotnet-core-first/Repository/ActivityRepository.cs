using be_dotnet_core_first.Database;
using be_dotnet_core_first.Interface;
using be_dotnet_core_first.Params;
using Microsoft.EntityFrameworkCore;

namespace be_dotnet_core_first.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _context;

        public ActivityRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<GetActivityInfoOutput> GetActivity(int actId)
        {

            var model = from a in _context.Activity
                        join c in _context.Category
                        on a.activityCategoryId equals c.categoryId 
                        into activityInfo
                        from c in activityInfo.DefaultIfEmpty()
                        where a.activityId == actId
                        select new GetActivityInfoOutput
                        {
                            activityId = a.activityId,
                            activityName = a.activityName,
                            categoryId = c.categoryId,
                            categoryName = c.categoryNameTh
                        };

            return model.FirstAsync();
        }
    }
}
