using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Controllers
{
    [Route("api/[controller]")] // from launchSettings.json our endPoint PORT is "applicationUrl": "https://localhost:7022
    // [controller] means the we will use the name of the current controller [SuperHero]Controller https://localhost:7022/api/SuperHero
    [ApiController]

    // for this demo we use a FatController where all the logic will be in it, the better way is to make services and inject them here where the controller will be only for the Requests.
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        //public async Task<IActionResult> GetAllHeroes()
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes() // like this we will see a new SuperHero Schema and a right example value in Swagger
        {
            var heroes = new List<SuperHero>
            {
                new() {
                    Id = 1,
                    Name = "SpiderMan",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York"
                }
            };

            return Ok(heroes);
        }

    }
}
