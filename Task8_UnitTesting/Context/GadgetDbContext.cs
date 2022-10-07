using Microsoft.EntityFrameworkCore;
using Task8_UnitTesting.Model;

namespace Task8_UnitTesting.Context
{
    public class GadgetDbContext:DbContext
    {
        public GadgetDbContext(DbContextOptions<GadgetDbContext>Context):base(Context)
        {

        }

        //table creation
        public DbSet<GadgetClass> GadgetTbl { get; set; }
    }
}
