using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entitiy;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Blazor.Data
{
    public class UserApi : IUserApi
    {
        private HttpClient client;

        public UserApi(HttpClient client)
        {
            this.client = client;
        }

        public async Task<User> RegisterNewUser(User user)
        {
            var serlizableUser = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(serlizableUser, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"users/register", content);
            if (response.IsSuccessStatusCode)
            {
                string responseString =await response.Content.ReadAsStringAsync();
                User responseUser = JsonConvert.DeserializeObject<User>(responseString);
                return responseUser;
            }

            throw new Exception("Error, not response");
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            User user = new User(userName, password);
            
            var serlizableUser = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(serlizableUser, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"users/login", content);
            if (response.IsSuccessStatusCode)
            {
                string responseString =await response.Content.ReadAsStringAsync();
                User responseUser = JsonConvert.DeserializeObject<User>(responseString);
                return responseUser;
            }

            throw new Exception("Error, not response");
        }
    }
}