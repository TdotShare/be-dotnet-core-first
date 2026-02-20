using be_dotnet_core_first.Database.Entity;

namespace be_dotnet_core_first.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetUserByUserId(int userId);
    }
}
