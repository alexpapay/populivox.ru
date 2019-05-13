using PopuliVoxRu.Domain.Interfaces.Common.Basic;

namespace PopuliVoxRu.Domain.Interfaces.Common.Generic
{
    public interface ISelectUpdateRepository<T> :
        ISelectRepository<T>,
        IUpdateRepository<T> where T : class, new()
    {
    }
}
