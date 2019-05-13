namespace PopuliVoxRu.Domain.Interfaces.Common.Basic
{
    public interface IRemoveRepository<T> where T : class, new()
    {
        /// <summary>
        /// Delete data from database.
        /// </summary>
        /// <param name="model">Model object.</param>
        /// <returns>Result: true or false.</returns>
        bool Remove(T model);
    }
}
