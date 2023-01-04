using Project_Models;

namespace CallAPIProject.Pages.Project.Services
{
    public class JsonPlaceholderData : IJsonPlaceholder
    {
        private readonly HttpClient httpClient;    
        public JsonPlaceholderData(HttpClient httpClient) 
        {
            this.httpClient = httpClient; 
        }

        public async Task<IEnumerable<Interface>> GetPlaceholderById(int id)
        {
            return await httpClient.GetFromJsonAsync<Interface[]>("posts/{id}");
        }

        public async Task<IEnumerable<Interface>> GetPlaceholderData()
        {
            return await httpClient.GetFromJsonAsync<Interface[]>("posts");
        }
    }
}
