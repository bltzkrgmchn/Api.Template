using Api.Template.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Template.Data
{
    /// <inheritdoc />
    public class PlaceholderRepository : IPlaceholderRepository
    {
        private readonly string connectionString;
        private readonly ILogger<PlaceholderRepository> logger;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PlaceholderRepository"/>.
        /// </summary>
        /// <param name="connectionString">Строка подключения.</param>
        /// <param name="logger">Абстракция над сервисом журналирования.</param>
        public PlaceholderRepository(string connectionString, ILogger<PlaceholderRepository> logger)
        {
            this.connectionString = connectionString;
            this.logger = logger;
        }

        /// <inheritdoc />
        public async Task<List<Placeholder>> Find()
        {
            this.logger.LogInformation("Выполняется поиск всех Placeholder в хранилище Placeholder.");

            using (PlaceholderContext context = new PlaceholderContext(this.connectionString))
            {
                DbSet<PlaceholderDto> dtos = context.Placeholders;
                return await dtos.Select(o => new Placeholder(o.Id)).ToListAsync();
            }
        }

        /// <inheritdoc />
        public async Task<Placeholder> Find(string id)
        {
            this.logger.LogInformation($"Выполняется поиск Placeholder с идентификатором '{id}' в хранилище Placeholder.");

            using (PlaceholderContext context = new PlaceholderContext(this.connectionString))
            {
                PlaceholderDto dto = await context.Placeholders.FirstOrDefaultAsync(o => o.Id == id);
                return dto != null ? new Placeholder(dto.Id) : null;
            }
        }
    }
}