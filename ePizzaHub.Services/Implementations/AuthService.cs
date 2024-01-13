using ePizzaHub.Core.Entities;
using ePizzaHub.Models;
using ePizzaHub.Repositories.Interfaces;
using ePizzaHub.Services.Interfaces;

namespace ePizzaHub.Services.Implementations
{
    public class AuthService : IAuthService
    {
        IUserRepository _userRepo;
        public AuthService(IUserRepository userRepo, IUserRepository userRepo1)
        {
            _userRepo = userRepo;
        }
        public bool CreateUser(User user, string role)
        {
            return _userRepo.CreateUser(user, role);
        }

        public UserModel ValidateUser(string email, string password)
        {
            UserModel model = _userRepo.ValidateUser(email, password);
            return model;
        }
    }
}
