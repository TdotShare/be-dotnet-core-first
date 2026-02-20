using be_dotnet_core_first.Database;
using be_dotnet_core_first.Database.Entity;
using be_dotnet_core_first.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace be_dotnet_core_first.Repository
{
    public class UserRepository : IUserRepository
    {
        // 1. ประกาศตัวแปร Private Field
        private readonly AppDbContext _context;

        // 2. ประกาศ Constructor เพื่อรับค่า (Dependency Injection)
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByUserId(int userId)
        {
            // 3. ใช้งานผ่าน _context
            return await _context.ActUsers.Where(e => e.userId == userId).FirstOrDefaultAsync();
        }
    }
}
