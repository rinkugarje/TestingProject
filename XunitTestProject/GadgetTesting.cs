using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8_UnitTesting.Controllers;
using Task8_UnitTesting.Model;
using Task8_UnitTesting.Services;

namespace XunitTestProject
{
   
    public class GadgetTesting
    {
        private readonly Mock<IGadgetService> gadgetService;

        public GadgetTesting()
        {
            gadgetService = new Mock<IGadgetService>();
        }

        [Fact]
        public void GetGadgetList()
        {
            //arrange
            var gadgetList = GetGadgetsData();
            gadgetService.Setup(a=>a.GetAllGadgets()).Returns(gadgetList);

            var gadgetController = new GadgetController(gadgetService.Object);

            //act
            var gadgetResult = gadgetController.GetAllGadgets();

            //assert
            Assert.NotNull(gadgetResult);
          
            //Assert.Equal(GetGadgetsData().ToString(), gadgetResult.ToString());
            //Assert.True(gadgetList.Equals(gadgetResult));

        }

        private List<GadgetClass> GetGadgetsData()
        {
            List<GadgetClass> gadgets = new List<GadgetClass>();
            {
                new GadgetClass
                {
                    GadgetId = 1,
                    GadgetName = "Samsung",
                    GadgetType = "Mobile",
                    GadgetPrice = 25000
                };
            }
            return gadgets;
        }
    }
}
