using BasicAuthenticationASP.Models;

namespace BasicAuthenticationASP.Services
{
    public interface IDataService
    {
        public Task<List<Data>> Get();
    }
}
