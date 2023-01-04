using Microsoft.AspNetCore.Components;
using Project_Models;

namespace CallAPIProject.Pages.Project.TokenService
{
    public class DisplayInventoryDataBase : ComponentBase
    {
        [Inject]
        public IGetInventoryData T { get; set; }
        /*protected override async Task OnInitializedAsync()
        {
             await T.GetAllData();
        }*/
    }
}
