using Project_Models;

namespace CallAPIProject.Pages.Project.Services
{
    public interface IJsonPlaceholder
    {
        Task<IEnumerable<Interface>> GetPlaceholderData();

        Task<IEnumerable<Interface>> GetPlaceholderById(int id);
    }
}
