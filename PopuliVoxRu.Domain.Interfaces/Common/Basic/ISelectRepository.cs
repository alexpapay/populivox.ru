namespace PopuliVoxRu.Domain.Interfaces.Common.Basic
{
    /// <summary>
    /// Base interface for selecting data from database (Get method).
    /// </summary>
    /// <typeparam name="T">Model type.</typeparam>
    public interface ISelectRepository<T> where T: class, new()
    {
        /// <summary>
        /// SelectBlueBars by id.
        /// </summary>
        /// <param name="id">Model id value.</param>
        /// <returns>Model object.</returns>
        T Select(int id);
    }
}
