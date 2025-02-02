using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DOCTPRO.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UserCreate()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return CreatedAtAction("AUMUpdateInEOD", new { status = "101", Response = true });
        }
    }
}
