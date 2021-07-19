using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Template.Core
{
    /// <summary>
    /// Хранилище Placeholder.
    /// </summary>
    public interface IPlaceholderRepository
    {
        /// <summary>
        /// Получает список Placeholder.
        /// </summary>
        /// <returns>Список Placeholder.</returns>
        Task<List<Placeholder>> Find();

        /// <summary>
        /// Получает Placeholder.
        /// </summary>
        /// <param name="id">Идентификатор Placeholder.</param>
        /// <returns>Placeholder.</returns>
        Task<Placeholder> Find(string id);
    }
}