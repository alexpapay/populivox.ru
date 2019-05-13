using PopuliVoxRu.Domain.Interfaces.Common.Basic;

namespace PopuliVoxRu.Domain.Interfaces.Common.Generic
{
    public interface ISelectInsertRepository<T> :
        ISelectRepository<T>,
        IInsertRepository<T> where T : class, new()
    {
    }
}
