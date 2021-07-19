namespace Api.Template.Core
{
    /// <summary>
    /// Placeholder.
    /// </summary>
    public class Placeholder
    {
        /// <summary>
        /// �������������� ����� ��������� ������ <see cref="Placeholder"/>.
        /// </summary>
        /// <param name="id">������������� Placeholder.</param>
        public Placeholder(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// �������� ������������� Placeholder.
        /// </summary>
        public string Id { get; private set; }
    }
}