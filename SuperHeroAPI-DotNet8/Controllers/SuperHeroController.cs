using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI_DotNet8.Controllers
{
    [Route("api/[controller]")] // from launchSettings.json our endPoint PORT is "applicationUrl": "https://localhost:7022
    // [controller] means the we will use the name of the current controller [SuperHero]Controller https://localhost:7022/api/SuperHero
    [ApiController]

    // for this demo we use a FatController where all the logic will be in it, the better way is to make services and inject them here where the controller will be only for the Requests.
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]

    }
}
