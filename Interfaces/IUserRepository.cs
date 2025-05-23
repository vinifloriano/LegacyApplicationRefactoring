using LegacyApplicationRefactoring.Models;
using System.Threading.Tasks;

namespace LegacyApplicationRefactoring.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByUsernameAsync(string username);
    }
}