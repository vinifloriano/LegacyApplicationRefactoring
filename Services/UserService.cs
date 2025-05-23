using LegacyApplicationRefactoring.Models;
using LegacyApplicationRefactoring.Interfaces;
using LegacyApplicationRefactoring.Repositories;

namespace LegacyApplicationRefactoring.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponseDto> GetWelcomeMessageAsync(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return new UserResponseDto
                {
                    Message = "Username is required."
                };
            }

            var user = await _userRepository.GetUserByUsernameAsync(username);

            return new UserResponseDto
            {
                Message = user != null ? $"Hello, {user.Name}" : "User not found."
            };
        }
    }
}