namespace Api.Template.Core
{
    /// <summary>
    /// Placeholder.
    /// </summary>
    public class Placeholder
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Placeholder"/>.
        /// </summary>
        /// <param name="id">������������� Placeholder.</param>
        public Placeholder(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Получает идентификатор Placeholder.
        /// </summary>
        public string Id { get; private set; }
    }
}