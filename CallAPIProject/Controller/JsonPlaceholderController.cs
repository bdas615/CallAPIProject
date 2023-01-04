using CallAPIProject.Pages.Project.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallAPIProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonPlaceholderController : ControllerBase
    {
        private readonly IJsonPlaceholder placeholder;

        public JsonPlaceholderController(IJsonPlaceholder placeholder) 
        {
            this.placeholder = placeholder;
        }
    }
}
