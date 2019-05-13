using PopuliVoxRu.Domain.Interfaces.Common.Basic;

namespace PopuliVoxRu.Domain.Interfaces.Common.Generic
{
    /// <summary>
    /// Generic repository for CRUD operations.
    /// </summary>
    /// <typeparam name="T">Model type.</typeparam>
    public interface IGenericRepository<T> :
        ISelectRepository<T>,
        IUpdateRepository<T>,
        IInsertRepository<T> ,
        IRemoveRepository<T> 
        where T : class, new()
    {
    }
}
