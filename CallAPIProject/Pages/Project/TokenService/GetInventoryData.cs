using Project_Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace CallAPIProject.Pages.Project.TokenService
{
    public class GetInventoryData : IGetInventoryData
    {
        private readonly HttpClient httpClient;
        public GetInventoryData(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /*public async Task<System.Net.Http.HttpResponseMessage> GetAllData()
        {
            AllDeviceData data = new AllDeviceData();

              string w = "A12F7A58-842D-4111-A44D-5F8C4E1AA521";
              int z = Convert.ToInt32("w");

            TokenClass TokenKey = new TokenClass("A12F7A58-842D-4111-A44D-5F8C4E1AA521");
              TokenClass TokenKey = new TokenClass("z");

            System.Net.Http.HttpResponseMessage x = await httpClient.PostAsJsonAsync("https://tools.brandinstitute.com/wsInventory/wsInventory.asmx/Device_GetAll", TokenKey);
        
            data = await x.Content.ReadFromJsonAsync<AllDeviceData>();
        
            return await httpClient.PostAsJsonAsync<TokenClass>("https://tools.brandinstitute.com/wsInventory/wsInventory.asmx/Device_GetAll", TokenKey);
          
        }*/

        public async Task GetAllData()
        {
            //AllDeviceData data = new AllDeviceData();

            var tokenKey = new[]
            {
                new KeyValuePair<string,string>("token","A12F7A58-842D-4111-A44D-5F8C4E1AA521")
            };

            var res = await httpClient.PostAsync("https://tools.brandinstitute.com/wsInventory/wsInventory.asmx/Device_GetAll", new FormUrlEncodedContent(tokenKey));
            string data = res.Content.ReadAsStringAsync().Result; 
            Console.WriteLine(data);

        }
    }
}