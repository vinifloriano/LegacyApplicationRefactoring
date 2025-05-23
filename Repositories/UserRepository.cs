using Dapper;
using LegacyApplicationRefactoring.Data;
using LegacyApplicationRefactoring.Interfaces;
using LegacyApplicationRefactoring.Models;
using System.Threading.Tasks;

namespace LegacyApplicationRefactoring.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "SELECT username, name FROM Users WHERE Username = @Username";
                return await connection.QueryFirstOrDefaultAsync<User>(query, new { Username = username });
            }
        }
    }
}