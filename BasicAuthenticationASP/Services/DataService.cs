using BasicAuthenticationASP.Models;
using System.Text.Json;

namespace BasicAuthenticationASP.Services
{
    public class DataService : IDataService
    {
        string path = @"D:\Desarrollo\Test_CRUD\Basic_Authentication\BasicAuthenticationASP\BasicAuthenticationASP\data.json";

        public async Task<List<Data>> Get()
        {
            string content = await File.ReadAllTextAsync(path);

            var datas = JsonSerializer.Deserialize<List<Data>>(content);

            return datas;
        }

    }
}
