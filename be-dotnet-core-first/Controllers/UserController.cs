using be_dotnet_core_first.Database.Entity;
using be_dotnet_core_first.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace be_dotnet_core_first.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet("GetUserByUserId/{userId}")]
        public Task<User?> GetUserByUserId(int userId)
        {
            return this.userRepository.GetUserByUserId(userId);
        }

    }
}
