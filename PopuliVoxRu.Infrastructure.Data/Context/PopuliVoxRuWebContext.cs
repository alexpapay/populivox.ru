using Microsoft.EntityFrameworkCore;

namespace PopuliVoxRu.Infrastructure.Data.Context
{
    public class PopuliVoxRuWebContext : DbContext
    {
        public PopuliVoxRuWebContext()
        {
        }

        public PopuliVoxRuWebContext(DbContextOptions<PopuliVoxRuWebContext> options)
        : base(options)
        {
        }
    }
}
