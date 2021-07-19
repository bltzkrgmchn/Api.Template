using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Template.Core
{
    /// <inheritdoc/>
    public class PlaceholderService : IPlaceholderService
    {
        private readonly IPlaceholderRepository placeholderRepository;
        private readonly ILogger<PlaceholderService> logger;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PlaceholderService"/>.
        /// </summary>
        /// <param name="placeholderRepository">Хранилище Placeholder.</param>
        /// <param name="logger">Абстракция над сервисом журналирования.</param>
        public PlaceholderService(IPlaceholderRepository placeholderRepository, ILogger<PlaceholderService> logger)
        {
            this.placeholderRepository = placeholderRepository;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<Placeholder> Get(string id)
        {
            this.logger.LogInformation($"Выполняется поиск Placeholder с идентификатором '{id}'.");
            return await this.placeholderRepository.Find(id);
        }

        /// <inheritdoc/>
        public async Task<List<Placeholder>> Get()
        {
            this.logger.LogInformation($"Выполняется поиск всех Placeholder.");
            return await this.placeholderRepository.Find();
        }
    }
}