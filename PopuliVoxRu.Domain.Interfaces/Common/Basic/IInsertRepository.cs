namespace PopuliVoxRu.Domain.Interfaces.Common.Basic
{
    /// <summary>
    /// Base interface for inserting data to database.
    /// </summary>
    /// <typeparam name="T">Model type.</typeparam>
    public interface IInsertRepository<T> where T : class, new()
    {
        /// <summary>
        /// Insert model.
        /// </summary>
        /// <param name="model">Model object.</param>
        /// <returns>Result: true or false.</returns>
        bool Insert(T model);
    }
}
