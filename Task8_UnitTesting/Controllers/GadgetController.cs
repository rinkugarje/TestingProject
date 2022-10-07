
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task8_UnitTesting.Model;
using Task8_UnitTesting.Services;

namespace Task8_UnitTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GadgetController : ControllerBase
    {
        readonly IGadgetService _gadgetService;
        public GadgetController(IGadgetService gadgetService)
        {
            _gadgetService = gadgetService;
        }

        [HttpGet]
        [Route("GetAllGadgets")]
        public IEnumerable<GadgetClass> GetAllGadgets()
        {
            var gadget = _gadgetService.GetAllGadgets().ToList();
            return gadget;
        }
    }
}
