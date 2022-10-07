using Task8_UnitTesting.Context;
using Task8_UnitTesting.Model;

namespace Task8_UnitTesting.Services
{
    public class GadgetService:IGadgetService
    {
        readonly GadgetDbContext _gadgetDbContext;
        public GadgetService(GadgetDbContext gadgetDbContext)
        {
            _gadgetDbContext = gadgetDbContext;
        }

        public IEnumerable<GadgetClass> GetAllGadgets()
        {
            return _gadgetDbContext.GadgetTbl.ToList();
        }
    }
}
