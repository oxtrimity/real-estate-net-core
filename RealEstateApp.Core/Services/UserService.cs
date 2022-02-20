using RealEstateApp.Core.Entities.UserAggregate;
using RealEstateApp.Core.Interfaces;

namespace RealEstateApp.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IAppLogger<UserService> _logger;

        public UserService(IRepository<User> userRepository,
            IAppLogger<UserService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }
    }
}
