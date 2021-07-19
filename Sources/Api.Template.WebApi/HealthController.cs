using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Template.WebApi
{
    /// <summary>
    /// Контроллер проверки состояния службы.
    /// </summary>
    [ApiController]
    [Route("/health")]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// Получить статус службы.
        /// </summary>
        /// <returns>Статус службы.</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return this.Ok();
        }
    }
}