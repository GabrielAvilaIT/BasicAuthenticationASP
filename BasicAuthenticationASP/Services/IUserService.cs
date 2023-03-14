namespace BasicAuthenticationASP.Services
{
    public interface IUserService
    {
        public bool IsUser(string email, string pass);
    }
}
