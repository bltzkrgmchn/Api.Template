using Api.Template.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Api.Template.WebApi
{
    /// <summary>
    /// Контроллер Placeholder.
    /// </summary>
    [ApiController]
    [Route("/placeholders")]
    public class PlaceholderController : ControllerBase
    {
        private readonly IPlaceholderService placeholderService;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PlaceholderController"/>.
        /// </summary>
        /// <param name="placeholderService">Сервис Placeholder.</param>
        public PlaceholderController(IPlaceholderService placeholderService)
        {
            this.placeholderService = placeholderService;
        }

        /// <summary>
        /// Метод для получения доступным методов.
        /// </summary>
        /// <returns>Список доступных методов.</returns>
        [HttpOptions]
        public IActionResult Options()
        {
            this.Response.Headers.Add("Allow", "GET, OPTIONS");
            return this.Ok();
        }

        /// <summary>
        /// Получить список Placeholder.
        /// </summary>
        /// <returns>Список Placeholder.</returns>
        [HttpGet]
        [ServiceFilter(typeof(AuthorizationFilter))]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var placeholders = await this.placeholderService.Get();
                return this.Ok(placeholders);
            }
            catch (Exception)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadGateway);
            }
        }

        /// <summary>
        /// Получить Placeholder.
        /// </summary>
        /// <param name="id">Идентификатор Placeholder.</param>
        /// <returns>Placeholder.</returns>
        [HttpGet]
        [Route("{id}")]
        [ServiceFilter(typeof(AuthorizationFilter))]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var placeholder = await this.placeholderService.Get(id);

                if (placeholder != null)
                {
                    return this.Ok(placeholder);
                }

                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }
            catch (Exception)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadGateway);
            }
        }
    }
}