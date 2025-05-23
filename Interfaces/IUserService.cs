using LegacyApplicationRefactoring.Models;
using System.Threading.Tasks;

namespace LegacyApplicationRefactoring.Interfaces
{
    public interface IUserService
    {
        Task<UserResponseDto> GetWelcomeMessageAsync(string username);
    }
}