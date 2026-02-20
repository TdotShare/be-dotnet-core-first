using be_dotnet_core_first.Database;
using be_dotnet_core_first.Params;

namespace be_dotnet_core_first.Interface
{
    public interface IActivityRepository
    {
        Task<GetActivityInfoOutput> GetActivity(int actId);
    }
}
