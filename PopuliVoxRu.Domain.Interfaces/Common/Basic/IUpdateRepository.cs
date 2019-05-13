namespace PopuliVoxRu.Domain.Interfaces.Common.Basic
{
    /// <summary>
    /// Base interface for updating data in database.
    /// </summary>
    /// <typeparam name="T">Model type.</typeparam>
    public interface IUpdateRepository<T> where T : class, new()
    {
        /// <summary>
        /// Update model.
        /// </summary>
        /// <param name="model">Model object.</param>
        /// <returns>Result: true or false.</returns>
        bool Update(T model);
    }
}
