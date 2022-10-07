using Task8_UnitTesting.Model;

namespace Task8_UnitTesting.Services
{
    public interface IGadgetService
    {
        IEnumerable<GadgetClass> GetAllGadgets();
    }
}
