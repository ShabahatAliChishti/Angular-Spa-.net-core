using Microsoft.EntityFrameworkCore;

namespace AngularSpaWithNetCore6._0.Data
{
    public class PurePacContext:DbContext
    {
        public PurePacContext(DbContextOptions<PurePacContext> options) : base(options) { }

    }
}
