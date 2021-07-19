using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Template.Core
{
    /// <summary>
    /// Сервисный объект для управления Placeholder.
    /// </summary>
    public interface IPlaceholderService
    {
        /// <summary>
        /// Получить Placeholder.
        /// </summary>
        /// <param name="id">Идентификатор Placeholder.</param>
        /// <returns>Placeholder.</returns>
        Task<Placeholder> Get(string id);

        /// <summary>
        /// Получить список Placeholder.
        /// </summary>
        /// <returns>Список Placeholder.</returns>
        Task<List<Placeholder>> Get();
    }
}