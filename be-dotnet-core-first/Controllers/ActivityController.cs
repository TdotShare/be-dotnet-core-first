using be_dotnet_core_first.Interface;
using be_dotnet_core_first.Params;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace be_dotnet_core_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {

        private IActivityRepository activityRepository; 
        public ActivityController(IActivityRepository activityRepository) {
            this.activityRepository = activityRepository;
        }

        [HttpGet("GetActivityInfo/{id}")]
        public Task<GetActivityInfoOutput> GetActivityInfo(int id)
        {
            return this.activityRepository.GetActivity(id);
        }
    }
}
