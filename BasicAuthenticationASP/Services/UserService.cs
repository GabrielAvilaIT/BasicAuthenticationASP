using BasicAuthenticationASP.Models;

namespace BasicAuthenticationASP.Services
{
    public class UserService : IUserService
    {

        List<User> users = new List<User>()
        {
            new User() { Email = "pepe@hotmail.com", Password = "123456"},
            new User() { Email = "pepe2@hotmail.com", Password = "654321"},
        };

        public bool IsUser(string email, string password) =>
            users.Where(d=>d.Email == email && d.Password == password).Count() > 0;
    }
}
