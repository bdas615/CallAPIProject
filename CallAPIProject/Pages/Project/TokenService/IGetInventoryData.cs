using Project_Models;

namespace CallAPIProject.Pages.Project.TokenService
{
    public interface IGetInventoryData
    {
      /*  Task<IEnumerable<GetAllDetails>> GetFullData();*/

        Task GetAllData();
    }
}
