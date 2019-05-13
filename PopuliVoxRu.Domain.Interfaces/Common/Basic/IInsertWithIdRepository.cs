namespace PopuliVoxRu.Domain.Interfaces.Common.Basic
{
    /// <summary>
    /// Base interface for inserting data to database with inserted row id value.
    /// </summary>
    /// <typeparam name="T">Model type.</typeparam>
    public interface IInsertWithIdRepository<T> where T : class, new()
    {
        /// <summary>
        /// Insert model.
        /// </summary>
        /// <param name="model">Model object.</param>
        /// <returns>Inserted row id value or null.</returns>
        int? InsertWithId(T model);
    }
}