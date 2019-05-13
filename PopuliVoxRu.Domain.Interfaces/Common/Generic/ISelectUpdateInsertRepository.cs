using PopuliVoxRu.Domain.Interfaces.Common.Basic;

namespace PopuliVoxRu.Domain.Interfaces.Common.Generic
{
    public interface ISelectUpdateInsertRepository<T> :
        ISelectRepository<T>,
        IUpdateRepository<T>,
        IInsertRepository<T> where T : class, new()
    {
    }
}